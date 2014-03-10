using System;
using System.Linq;
using System.Xml.Linq;

namespace FestoProj.Helpers {
    public static class XElementExtensions {
        public static string GetElementValue(this XElement node, string elementName) {
            var element = node.Descendants("Property").FirstOrDefault(x => x.Attribute("name").Value.Equals(elementName));
            if (element == null) {
                throw new ArgumentException(string.Format("Can't find xml node with next attribute '{0}'", elementName));
            }
            return element.Attribute("value").Value;
        }
    }
}