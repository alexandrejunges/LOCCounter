using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace LOCCounter.Domain.Rules
{
    public abstract class LOCSizeRuleBase
    {
        public abstract string Type { get; }        
        public int Order { get; set; }
        public string Value { get; set; }
        public double LOCValue { get; set; }

        [XmlIgnore]
        public string Description { get { return Translate(); } }

        public abstract string Translate();
        public abstract bool Validate(string line);

        public void Save(string filePath)
        {
            XmlSerializer xmlSerializaer = new XmlSerializer(this.GetType());
            using (StreamWriter file = new StreamWriter(filePath))
            {
                xmlSerializaer.Serialize(file, this);
            }
        }
    }
}