namespace FestoProj.Hardware {
    public class RAM : Device {
        public RAM(string deviceName, string manufacturerCompanyName, int cost, MemoryType memoryType, int size)
            : base(manufacturerCompanyName, cost, deviceName) {
            MemoryType = memoryType;
            Size = size;
        }

        public MemoryType MemoryType { get; private set; }

        public int Size { get; private set; }

        protected bool Equals(RAM other) {
            return base.Equals(other) && MemoryType == other.MemoryType && Size == other.Size;
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) {
                return false;
            }
            if (ReferenceEquals(this, obj)) {
                return true;
            }
            return obj.GetType() == GetType() && Equals((RAM) obj);
        }

        public override int GetHashCode() {
            unchecked {
                var hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ (int) MemoryType;
                hashCode = (hashCode * 397) ^ Size;
                return hashCode;
            }
        }
    }
}