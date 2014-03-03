namespace FestoProj.Hardware {
    public class MotherBoard : Device {
        private FormFactor formFactor;
        private string socketName;

        public MotherBoard(string manufacturerCompanyName, int cost, FormFactor formFactor, string socketName) : base(manufacturerCompanyName, cost) {
            this.formFactor = formFactor;
            this.socketName = socketName;
        }
    }
}