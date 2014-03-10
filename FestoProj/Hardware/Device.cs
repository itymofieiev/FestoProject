using System;

namespace FestoProj.Hardware {
    public abstract class Device {
        protected Device(string manufacturerCompanyName, int cost) {
            if (manufacturerCompanyName == null) {
                throw new ArgumentNullException("manufacturerCompanyName");
            }
            ManufacturerCompanyName = manufacturerCompanyName;
            Cost = cost;
        }

        public string ManufacturerCompanyName { get; private set; }

        public int Cost { get; private set; }

        protected bool Equals(Device other) {
            return string.Equals(ManufacturerCompanyName, other.ManufacturerCompanyName) && Cost == other.Cost;
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) {
                return false;
            }
            if (ReferenceEquals(this, obj)) {
                return true;
            }
            return obj.GetType() == GetType() && Equals((Device) obj);
        }

        public override int GetHashCode() {
            unchecked {
                return (ManufacturerCompanyName.GetHashCode() * 397) ^ Cost;
            }
        }
    }
}