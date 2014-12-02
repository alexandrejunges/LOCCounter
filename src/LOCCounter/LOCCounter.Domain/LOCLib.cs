using LOCCounter.Domain.Rules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace LOCCounter.Domain
{
    public static class LOCLib
    {
        public static List<LOCSizeRuleBase> ReadCountingSizeRules(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                throw new ArgumentException("File doesn't exists.");

            List<LOCSizeRuleBase> listOfRules = new List<LOCSizeRuleBase>();

            XDocument xmlDoc = XDocument.Load(filePath);

            var ruleTypes = (from classes in Assembly.GetExecutingAssembly().GetTypes()
                            where classes.IsClass 
                                    && classes.IsSerializable
                                    && classes.Namespace == "LOCCounter.Domain.Rules"
                            select classes).ToList();

            foreach (Type ruleType in ruleTypes)
            {
                var xmlAttribute = (ruleType.GetCustomAttribute(typeof(XmlRootAttribute)) as XmlRootAttribute);

                if (xmlAttribute != null)
                {
                    var rootElementName = xmlAttribute.ElementName;
                    var rules = xmlDoc.Descendants(rootElementName);

                    foreach (var ruleElement in rules)
                    {
                        XmlSerializer deserializer = new XmlSerializer(ruleType);
                        listOfRules.Add(deserializer.Deserialize(ruleElement.CreateReader()) as LOCSizeRuleBase);
                    }
                }
            }

            return listOfRules;
        }

        public static string GetFileName(string filePath, string extension)
        {
            var startIndex = filePath.LastIndexOf("/") + 1;
            var endIndex = filePath.IndexOf(extension) - 2;
            return filePath.Substring(startIndex, endIndex - startIndex);
        }

        public static string GetPath(string filePath)
        {
            var startIndex = filePath.LastIndexOf(@"/") + 1;

            if (startIndex == 0)
                startIndex = filePath.LastIndexOf(@"\") + 1;

            return filePath.Remove(startIndex);
        }
    }
}