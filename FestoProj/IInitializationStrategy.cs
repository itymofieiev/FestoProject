using System.Xml.Linq;
using FestoProj.Hardware;

namespace FestoProj {
    public interface IInitializationStrategy<out T> where T : Device {
        T Initialize(XElement node);
    }
}