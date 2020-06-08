using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace EthSharp.Compiler
{
    public class Compiler
    {
        public Stack Lines { get; set; }

        public IList<Contract> Contracts { get; set; }

        public Boolean Compile(String file)
        {
            Parse(file);
            return true;
        }

        public void Parse(String file)
        {
            this.Lines = new Stack();
            this.Contracts = new List<Contract>();

            Int32 i = 0;
            foreach (string line in File.ReadLines(file))
            {
                if (String.IsNullOrWhiteSpace(line))
                {
                    Line x = new Line() { Number = i, LineType = LineType.WHITE_SPACE };
                    Lines.Push(x);
                }

                if (line.Trim().Contains("pragma"))
                {
                    Line x = new Line() { Number = i, LineType = LineType.PRAGMA };
                    Lines.Push(x);
                }

                if (line.Trim().Contains("contract"))
                {
                    Line x = new Line() { Number = i, LineType = LineType.BEGIN_CONTRACT };
                    Lines.Push(x);
                }

                if (line.Trim().Contains("function"))
                {
                    Line x = new Line() { Number = i, LineType = LineType.BEGIN_FUNCTION };
                    Lines.Push(x);
                }

                if (line.Trim().StartsWith("}"))
                {
                    Line x = new Line() { Number = i, LineType = LineType.END };
                    Lines.Push(x);
                }

                i++;
            }

            
        }
    }
}
