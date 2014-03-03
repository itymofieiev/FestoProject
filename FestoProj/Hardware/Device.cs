namespace FestoProj.Hardware {
    public abstract class Device {
        private string manufacturerCompanyName;
        private int cost;

        protected Device(string manufacturerCompanyName, int cost) {
            this.manufacturerCompanyName = manufacturerCompanyName;
            this.cost = cost;
        }
    }
}