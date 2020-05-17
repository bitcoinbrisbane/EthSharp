using System;

namespace EthSharp.Compiler
{
    public class Contract
    {
        public String Pragma { get; set; }

        public String Name { get; set; }

        public Line[] Lines { get; set; }

        public Byte[] Compiled { get; set; }
    }
}