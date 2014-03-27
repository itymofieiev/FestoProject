using System;

namespace FestoProj.Hardware {
    public class Device {
        public Device(string manufacturerCompanyName, int cost, string name) {
            if (manufacturerCompanyName == null) {
                throw new ArgumentNullException("manufacturerCompanyName");
            }
            if (name == null) {
                throw new ArgumentNullException("name");
            }
            Name = name;
            ManufacturerCompanyName = manufacturerCompanyName;
            Cost = cost;
        }

        public string ManufacturerCompanyName { get; private set; }

        public int Cost { get; private set; }

        public string Name { get; private set; }

        protected bool Equals(Device other) {
            return string.Equals(ManufacturerCompanyName, other.ManufacturerCompanyName) && Cost == other.Cost && string.Equals(Name, other.Name);
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
                var hashCode = ManufacturerCompanyName != null ? ManufacturerCompanyName.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ Cost;
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}