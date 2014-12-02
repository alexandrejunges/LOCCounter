using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace LOCCounter.Domain.Rules
{
    [Serializable]
    [XmlRoot(ElementName = "BasicRule", IsNullable = true)]
    public class BasicLOCSizeRule : LOCSizeRuleBase
    {
        [XmlIgnore]
        public override string Type { get { return "Basic"; } }
        public ComparationModeEnum ComparationMode { get; set; }
        public override bool Validate(string line)
        {
            switch (ComparationMode)
            {
                case ComparationModeEnum.EqualsTo: return line.Equals(Value);
                case ComparationModeEnum.NotEqualsTo: return !line.Equals(Value);
                case ComparationModeEnum.StartsWith: return line.StartsWith(Value);
                case ComparationModeEnum.EndsWith: return line.EndsWith(Value);
                case ComparationModeEnum.Contains: return line.Contains(Value);
                case ComparationModeEnum.NotContains: return !line.Contains(Value);
                default: throw new NotImplementedException(string.Format("Mode '{0}' not impleted.", ComparationMode));
            }
        }

        public override string Translate()
        {
            var enumType = typeof(ComparationModeEnum);
            var memInfo = enumType.GetMember(ComparationMode.ToString());
            var attributes = memInfo.FirstOrDefault().GetCustomAttributes(typeof(DescriptionAttribute), false);

            var comparationModeDescription = ComparationMode.ToString();
            if(attributes != null)
                comparationModeDescription = ((DescriptionAttribute)attributes.FirstOrDefault()).Description;

            return string.Format("line {0} '{1}'", comparationModeDescription, Value);
        }
    }

    public enum ComparationModeEnum
    {
        [Description("==")]
        EqualsTo,
        [Description("!=")]
        NotEqualsTo,
        [Description("Starts with")]
        StartsWith,
        [Description("Ends with")]
        EndsWith,
        [Description("Contains")]
        Contains,
        [Description("Not Contains")]
        NotContains
    }
}