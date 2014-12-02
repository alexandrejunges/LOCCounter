using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LOCCounter.Domain.Rules
{
    [Serializable]
    [XmlRoot(ElementName = "RegExpRule", IsNullable = true)]
    public class RegExpLOCSizeRule : LOCSizeRuleBase
    {
        [XmlIgnore]
        public override string Type { get { return "RegExp"; } }

        public override string Translate()
        {
            return string.Format("Regex.IsMatch(line, '{0}')", Value);
        }
        public override bool Validate(string line)
        {
            return Regex.IsMatch(line, Value);
        }
    }
}