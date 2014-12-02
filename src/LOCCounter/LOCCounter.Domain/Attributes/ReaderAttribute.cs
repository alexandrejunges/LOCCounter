using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOCCounter.Domain.Attributes
{
    public class ReaderAttribute : Attribute
    {
        public string Extension { get; private set; }

        public ReaderAttribute(string extension)
        {
            this.Extension = extension;
        }
    }
}