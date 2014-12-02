using LOCCounter.Domain.Attributes;
using LOCCounter.Domain.Readers;
using LOCCounter.Domain.Rules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LOCCounter.Domain
{
    // TODO - Implement ignored files

    public class LOCSizeCounter
    {
        private IReader _Reader;	
        private List<LOCSizeRuleBase> _Rules;
        private Dictionary<string, LOCClassInfo> _Classes;

	    public int NumberOfClasses { get { return _Classes.Count; } }

        public double TotalLOC { get; private set; }

        public double AverageLOCSizePerClass { get { return NumberOfClasses == 0 ? 0 : TotalLOC / NumberOfClasses; } }

        public IEnumerable<LOCClassInfo> Classes { get { return _Classes.Values.ToList().AsReadOnly(); } }

        private LOCSizeCounter(string filePath)
        {
            _Rules = new List<LOCSizeRuleBase>();
            _Classes = new Dictionary<string,LOCClassInfo>();

            if (!File.Exists(filePath))
                throw new FileNotFoundException("File doesn't exists!");

            var readers = (from classes in Assembly.GetExecutingAssembly().GetTypes()
                           where classes.IsClass
                                    && typeof(IReader).IsAssignableFrom(classes)
                           select classes).ToList();

            // Define file's type
            foreach (var readerType in readers)
            {
                var readerAttribute = readerType.GetCustomAttribute<ReaderAttribute>();

                if (readerAttribute == null)
                    continue;

                if (filePath.EndsWith(readerAttribute.Extension))
                {
                    _Reader = Activator.CreateInstance(readerType, filePath) as IReader;
                    break;
                }
            }

            if(_Reader == null)
                throw new Exception("This kind of file is not supported.");
        }

	    public LOCSizeCounter(string filePath, string rulesFilePath)
            : this(filePath)
	    { 	
            // Load LOC couting size rules
            SetRules(rulesFilePath);
	    }

        public LOCSizeCounter(string filePath, List<LOCSizeRuleBase> rules)
            : this(filePath)
        {
            SetRules(rules);
        }

        public void SetRules(List<LOCSizeRuleBase> rules)
        {
            _Rules = rules;
        }

        public void SetRules(string rulesFilePath)
        {
            _Rules = LOCLib.ReadCountingSizeRules(rulesFilePath).ToList();
        }

        public double Count()
        {
            TotalLOC = 0;
            _Classes = new Dictionary<string, LOCClassInfo>();

            var classes = _Reader.Read();
            foreach (LOCClassInfo classInfo in classes)
            {
                _Classes.Add(classInfo.ClassName, classInfo);
                TotalLOC += classInfo.Contar(_Rules);
            }

            return TotalLOC;
        }
    }
}