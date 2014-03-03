namespace FestoProj.Hardware {
    public class RAM : Device {
        private MemoryType memoryType;
        private int size;

        public RAM(string manufacturerCompanyName, int cost, MemoryType memoryType, int size) : base(manufacturerCompanyName, cost) {
            this.memoryType = memoryType;
            this.size = size;
        }
    }
}