using System.Collections.Generic;
using System.Xml.Linq;
using FestoProj.Helpers;
using Newtonsoft.Json.Linq;

namespace FestoProj {
    public interface IComputerFactory {
        Computer Create(IDictionary<DeviceTypeDto, XElement> hardwareWithTypes);

        Computer Create(IEnumerable<JObject> devices);
    }
}