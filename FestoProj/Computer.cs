using System;
using System.Collections.Generic;
using FestoProj.Hardware;

namespace FestoProj {
    public class Computer {
        public Computer(IEnumerable<Device> equipment) {
            if (equipment == null) {
                throw new ArgumentNullException("equipment");
            }
            Equipment = equipment;
        }

        public IEnumerable<Device> Equipment { get; private set; }
    }
}