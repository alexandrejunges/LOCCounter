using LOCCounter.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LOCCounter.Domain.Readers
{
    [Reader(".sln")]
    public class SolutionReader : IReader
    {
        public string FilePath { get; private set; }

        public SolutionReader(string filepath)
        {
            FilePath = filepath;
        }

        public List<LOCClassInfo> Read()
        {
            var pathBase = LOCLib.GetPath(FilePath);
            List<ProjectReader> projects = new List<ProjectReader>();

            // Identify projects in the solution
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Project("))
                    {
                        var values = line.Split(',');
                        projects.Add(new ProjectReader(pathBase + values[1].ToString().Replace("\"", "").Trim()));
                    }
                    else if (line.Equals("Global"))
                    {
                        break;
                    }
                }
            }

            // Read the project to identify their classes
            List<LOCClassInfo> listOfClasses = new List<LOCClassInfo>();
            foreach (var proj in projects)
                listOfClasses.AddRange(proj.Read());

            return listOfClasses;
        }
    }
}