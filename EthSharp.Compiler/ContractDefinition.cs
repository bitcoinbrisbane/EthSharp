
using System;

namespace EthSharp.Compiler
{
    public class ContractDefinition
    {
        public String Pragma { get; set; }

        public String Name { get; set; }

        public Line[] Lines { get; set; }

        public Byte[] Compiled { get; set; }

        public Int32 StartLineNumber { get; set; }

        public Int32 EndLineNumber { get; set; }
    }
}