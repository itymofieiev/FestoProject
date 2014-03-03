using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace FestoProj {
    internal class Program {
        private static void Main(string[] args) {
            var container = new Container();
            container.Initialize();
            var test = new ComputerConfigurationExtractor("InitConfig.xml");
            test.Extarct();
        }
    }
}