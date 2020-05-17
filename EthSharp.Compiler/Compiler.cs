using System;

namespace EthSharp.Compiler
{
    public class Compiler
    {
        public Boolean Compile(String file)
        {
            GetLines(file);

            return true;
        }

        public Stack Parse(String file)
        {
            Stack lines = new Stack();
            Int32 i = 0;
            foreach (string line in File.ReadLines(file))
            {
                if (line.Contains("pragma"))
                {
                    Line x = new Line() { Number = i, LineType = LineType.PRAGMA };
                    lines.Push(x);
                    i++;
                }

                if (line.Contains("contract"))
                {
                    Line x = new Line() { Number = i, LineType = LineType.BEGIN_CONTRACT };
                    lines.Push(x);
                    i++;
                }

                if (line.Contains("function"))
                {
                    Line x = new Line() { Number = i, LineType = LineType.BEGIN_FUNCTION };
                    lines.Push(x);
                    i++;
                }
            }

            return lines;
        }
    }
}
