using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using FestoProj.Hardware;

namespace FestoProj {
    public class ComputerComputerFactory : IComputerFactory {
        private readonly IDictionary<string, IInitializationStrategy<Device>> initializationStrategies;

        public ComputerComputerFactory(IDictionary<string, IInitializationStrategy<Device>> initializationStrategies) {
            if (initializationStrategies == null) {
                throw new ArgumentNullException("initializationStrategies");
            }
            this.initializationStrategies = initializationStrategies;
        }

        public Computer Create(IDictionary<string, XElement> hardwareWithTypes) {
            var equipment = initializationStrategies.Join(hardwareWithTypes, x => x.Key, y => y.Key, (x, y) => new { Strategy = x.Value, InitData = y.Value })
                                                    .Select(x => x.Strategy.Initialize(x.InitData)).ToList();
            return new Computer(equipment);
        }
    }
}