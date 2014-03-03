using System.Collections.Generic;
using System.Xml.Linq;

namespace FestoProj {
    public interface IComputerConfigurationExtractor {
        IDictionary<string, XElement> Extarct();
    }
}