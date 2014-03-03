namespace FestoProj.Hardware {
    public class Processor : Device {
        private int coresNumber;
        private string socketName;

        public Processor(string manufacturerCompanyName, int cost, int coresNumber, string socketName) : base(manufacturerCompanyName, cost) {
            this.coresNumber = coresNumber;
            this.socketName = socketName;
        }
    }
}