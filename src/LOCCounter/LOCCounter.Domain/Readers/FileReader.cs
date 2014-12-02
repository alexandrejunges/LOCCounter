using LOCCounter.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOCCounter.Domain.Readers
{
    [Reader(".cs")]
    public class FileReader : IReader
    {
        public string FilePath { get; private set; }

        public FileReader(string filepath)
        {
            FilePath = filepath;
        }

        public List<LOCClassInfo> Read()
        {
            return new List<LOCClassInfo>() 
            { 
                new LOCClassInfo(FilePath)
            };
        }
    }
}