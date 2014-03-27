using System.Collections.Generic;
using System.Xml.Linq;
using FestoProj.Helpers;
using Newtonsoft.Json.Linq;

namespace FestoProj {
    public interface IComputerConfigurationExtractor {
        IDictionary<DeviceTypeDto, XElement> ExtarctFromXml(string xmlFilePath);

        IEnumerable<JObject> ExtractFromJson(string jsonFilePath);
    }
}