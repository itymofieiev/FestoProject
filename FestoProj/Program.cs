using FestoProj.Hardware;

namespace FestoProj {
    internal class Program {
        private static void Main(string[] args) {
            var container = new Container();
            container.Initialize();
            var test = new ComputerConfigurationExtractor("InitConfig.xml");
            var anotherTest = test.Extarct();
            var factory = container.Resolve<IComputerFactory>();
            var computer = factory.Create(anotherTest);
            var test2 = computer.DynamicValueFor<Processor>();
        }
    }
}