using System;
using System.Collections;
using System.IO;

namespace EthSharp
{
    public class Compiler
    {
        public Boolean Compile(String file)
        {
            GetLines(file);

            return true;
        }

        public void GetLines(String file)
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
            }
        }
    }
}