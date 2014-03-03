using System;
using System.Xml.Linq;
using FestoProj.Hardware;
using FestoProj.Helpers;

namespace FestoProj {
    public class RamIinitializationInitializationStrategy : IInitializationStrategy<RAM> {
        public RAM Initialize(XElement node) {
            var manufacutreCompany = node.GetElementValue("manufacturerCompanyName");
            var cost = Convert.ToInt32(node.GetElementValue("cost"));
            var size = Convert.ToInt32(node.GetElementValue("size"));
            var memoryType = node.GetElementValue("memoryType");
            return new RAM(manufacutreCompany, cost, (MemoryType) Enum.Parse(typeof(MemoryType), memoryType), size);
        }
    }
}