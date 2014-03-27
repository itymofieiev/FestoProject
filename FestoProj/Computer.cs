using System;
using System.Collections.Generic;
using System.Linq;
using FestoProj.Hardware;
using FestoProj.Helpers;

namespace FestoProj {
    public class Computer {
        public Computer(IEnumerable<Device> equipments) {
            if (equipments == null) {
                throw new ArgumentNullException("equipments");
            }
            Equipments = equipments;
        }

        public IEnumerable<Device> Equipments { get; private set; }

        public T DynamicValueFor<T>() where T : Device {
            var equipment = Equipments.FirstOrDefault(x => (x as T) != null);
            if (equipment == null) {
                throw new EquipmentNotFoundException("Equipment '{0}' was not found".Fmt(typeof(T).Name));
            }
            return (T) equipment;
        }
    }
}