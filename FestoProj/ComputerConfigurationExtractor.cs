using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace FestoProj {
    public class ComputerConfigurationExtractor : IComputerConfigurationExtractor {
        private readonly XContainer config;

        public ComputerConfigurationExtractor(string filePath) {
            config = XDocument.Load(filePath);
        }

        public IDictionary<string, XElement> Extarct() {
            return config.XPathSelectElements("Computer/Properties/Property").ToDictionary(k => k.Attribute("dataType").Value, v => v);
        }
    }
}