using System.Xml.Linq;
using FestoProj.Hardware;
using Newtonsoft.Json.Linq;

namespace FestoProj {
    public interface IInitializationStrategy<out T> where T : Device {
        T InitializeFrom(XElement node, string deviceName);

        T InitializeFrom(JObject rawDevice);

        string GenerateReportForDeviceComparison(object actualObj, object expectedObj);
    }
}