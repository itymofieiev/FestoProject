using System;

namespace FestoProj {
    internal class Program {
        private static void Main(string[] args) {
            var container = new Container();
            container.Initialize();
            var extractor = container.Resolve<IComputerConfigurationExtractor>();
            var configurationFromXml = extractor.ExtarctFromXml("InitConfig.xml");
            var configurationFromJson = extractor.ExtractFromJson("TestingConfig.json");
            var factory = container.Resolve<IComputerFactory>();
            var computer = factory.Create(configurationFromXml);
            var requiredComputer = factory.Create(configurationFromJson);
            var deviceTestiong = container.Resolve<IDeviceTesting>();
            Console.WriteLine(string.Join("\r\n", deviceTestiong.Analyze(computer, requiredComputer)));
            Console.ReadKey();
        }
    }
}