using System.Xml.Linq;
using System.Xml.XPath;

namespace FestoProj.Helpers {
    public static class XElementExtensions {
        public static string GetElementValue(this XElement node, string elementName) {
            return node.XPathSelectElement(string.Format("Properties/Property[contains(@name, '{0}')]", elementName)).Attribute("value").Value;
        }
    }
}