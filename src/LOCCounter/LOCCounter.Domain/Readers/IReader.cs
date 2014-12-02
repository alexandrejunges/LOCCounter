using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOCCounter.Domain.Readers
{
    public interface IReader
    {
        string FilePath { get; }

        List<LOCClassInfo> Read();
    }
}