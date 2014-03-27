using System;

namespace FestoProj.Hardware {
    public class MotherBoard : Device {
        public MotherBoard(string deviceName, string manufacturerCompanyName, int cost, FormFactor formFactor, string socketName)
            : base(manufacturerCompanyName, cost, deviceName)
        {
            if (socketName == null) {
                throw new ArgumentNullException("socketName");
            }
            FormFactor = formFactor;
            SocketName = socketName;
        }

        public FormFactor FormFactor { get; private set; }

        public string SocketName { get; private set; }

        protected bool Equals(MotherBoard other) {
            return base.Equals(other) && FormFactor == other.FormFactor && string.Equals(SocketName, other.SocketName);
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) {
                return false;
            }
            if (ReferenceEquals(this, obj)) {
                return true;
            }
            return obj.GetType() == GetType() && Equals((MotherBoard) obj);
        }

        public override int GetHashCode() {
            unchecked {
                var hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ (int) FormFactor;
                hashCode = (hashCode * 397) ^ (SocketName != null ? SocketName.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}