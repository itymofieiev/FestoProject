using System;
using System.Xml.Linq;
using FestoProj.Hardware;
using FestoProj.Helpers;

namespace FestoProj {
    public class ProcessorInitializationInitializationStrategy : IInitializationStrategy<Processor> {
        public Processor Initialize(XElement node) {
            var manufacutreCompany = node.GetElementValue("manufacturerCompanyName");
            var cost = Convert.ToInt32(node.GetElementValue("cost"));
            var coresNumber = Convert.ToInt32(node.GetElementValue("coresNumber"));
            var socketName = node.GetElementValue("socketName");
            return new Processor(manufacutreCompany, cost, coresNumber, socketName);
        }
    }
}