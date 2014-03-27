using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using FestoProj.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FestoProj {
    public class ComputerConfigurationExtractor : IComputerConfigurationExtractor {
        public IDictionary<DeviceTypeDto, XElement> ExtarctFromXml(string xmlFilePath) {
            var config = XDocument.Load(xmlFilePath);

            return config.XPathSelectElements("Computer/Properties/Property")
                         .ToDictionary(k => new DeviceTypeDto(k.Attribute("name").Value, k.Attribute("dataType").Value), v => v);
        }

        public IEnumerable<JObject> ExtractFromJson(string jsonFilePath) {
            var json = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<IEnumerable<JObject>>(json);
        }
    }
}