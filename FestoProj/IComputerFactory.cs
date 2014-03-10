using System.Collections.Generic;
using System.Xml.Linq;
using FestoProj.Hardware;

namespace FestoProj {
    public interface IComputerFactory {
        Computer Create(IDictionary<string, XElement> hardwareWithTypes);
    }
}