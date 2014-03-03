using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using FestoProj.Hardware;

namespace FestoProj {
    public class ComputerComputerFactory : IComputerFactory {
        public Computer Create(IDictionary<string, IInitializationStrategy<Device>> initializationStrategies, IDictionary<string, XElement> hardwareWithTypes) {
            var equipment = initializationStrategies.Join(hardwareWithTypes, x => x.Key, y => y.Key, (x, y) => new { Strategy = x.Value, InitData = y.Value })
                                                    .Select(x => x.Strategy.Initialize(x.InitData)).ToList();
            return new Computer(equipment);
        }
    }
}