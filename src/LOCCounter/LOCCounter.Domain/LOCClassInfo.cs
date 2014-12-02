using LOCCounter.Domain.Rules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOCCounter.Domain
{
    public class LOCClassInfo
    {
        public string ClassName { get; private set; }
        public string FilePath { get; private set; }

	    public double TotalLOC { get; private set; }
	    public int NumberOfMethods { get; private set; }
        public double AverageMethodSize { get { return TotalLOC / NumberOfMethods; } }

        public LOCClassInfo(string filepath)
        {
            FilePath = filepath;
            ClassName = LOCLib.GetFileName(filepath, "cs");
        }

        public bool IsMethod(string linha)
        {
            // TODO - Improve!
            return linha.Contains("(")
                    && linha.Contains(")")
                    && !linha.Contains("=")
                    && (linha.StartsWith("public")
                            || linha.StartsWith("private")
                            || linha.StartsWith("protected"));
        }

        private bool ChecksComplexCodeClosure(List<string> linhas, int index)
        {
            int nroLinhas = linhas.Count;
            for (int x = index + 1; x < nroLinhas; x++)
            {
                String linha = linhas[x].Trim().ToUpper();
                if (linha.EndsWith("BEGIN COMPLEXCODE"))
                    return false;

                if (linha.EndsWith("END COMPLEXCODE"))
                    return true;
            }

            return false;
        }

        public double Contar(IEnumerable<LOCSizeRuleBase> rules)
        {
            TotalLOC = 0;
            NumberOfMethods = 0;

            string line = string.Empty;

            using (StreamReader reader = new StreamReader(FilePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();

                    if (IsMethod(line))
                    {
                        NumberOfMethods++;
                    }

                    var rule = rules.FirstOrDefault(r => r.Validate(line));
                    TotalLOC += rule.LOCValue;
                }
            }

            return TotalLOC;
        }
    }
}