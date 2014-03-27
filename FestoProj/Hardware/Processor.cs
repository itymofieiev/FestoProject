using System;

namespace FestoProj.Hardware {
    public class Processor : Device {
        public Processor(string deviceName, string manufacturerCompanyName, int cost, int coresNumber, string socketName)
            : base(manufacturerCompanyName, cost, deviceName) {
            if (socketName == null) {
                throw new ArgumentNullException("socketName");
            }
            CoresNumber = coresNumber;
            SocketName = socketName;
        }

        public int CoresNumber { get; private set; }

        public string SocketName { get; private set; }

        protected bool Equals(Processor other) {
            return base.Equals(other) && CoresNumber == other.CoresNumber && string.Equals(SocketName, other.SocketName);
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) {
                return false;
            }
            if (ReferenceEquals(this, obj)) {
                return true;
            }
            return obj.GetType() == GetType() && Equals((Processor) obj);
        }

        public override int GetHashCode() {
            unchecked {
                var hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ CoresNumber;
                hashCode = (hashCode * 397) ^ (SocketName != null ? SocketName.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}