using LOCCounter.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LOCCounter.Domain.Readers
{
    [Reader(".csproj")]
    public class ProjectReader : IReader
    {
        public string FilePath { get; private set; }

        public ProjectReader(string filepath)
        {
            FilePath = filepath;
        }

        public List<LOCClassInfo> Read()
        {
            List<FileReader> classes = new List<FileReader>();
            var pathBase = LOCLib.GetPath(FilePath);

            XDocument xmlDoc = XDocument.Load(FilePath);
            var xmlClasses = xmlDoc.Descendants().Elements().Where(x => x.Name.ToString().Contains("Compile"));

            foreach (var xmlClass in xmlClasses)
            {
                var classPath = xmlClass.Attribute("Include").Value;
                classes.Add(new FileReader(pathBase + classPath));
            }

            List<LOCClassInfo> listOfClasses = new List<LOCClassInfo>();
            foreach (var file in classes)
                listOfClasses.AddRange(file.Read());

            return listOfClasses;
        }
    }
}