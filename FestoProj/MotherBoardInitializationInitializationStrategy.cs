using System;
using System.Xml.Linq;
using FestoProj.Hardware;
using FestoProj.Helpers;

namespace FestoProj {
    public class MotherBoardInitializationInitializationStrategy : IInitializationStrategy<MotherBoard> {
        public MotherBoard Initialize(XElement node) {
            var manufacutreCompany = node.GetElementValue("manufacturerCompanyName");
            var cost = Convert.ToInt32(node.GetElementValue("cost"));
            var formFactor = node.GetElementValue("formFactor");
            var socketName = node.GetElementValue("socketName");
            return new MotherBoard(manufacutreCompany, cost, (FormFactor) Enum.Parse(typeof(FormFactor), formFactor), socketName);
        }
    }
}