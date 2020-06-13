using System;

namespace EthSharp.Compiler
{
    public class Function
    {
        public String Name { get; set; }

        public String Access { get; set; }

        public DataType DataType { get; set; }

        public Int32 StartLineNumber { get; set; }

        public Int32 EndLineNumber { get; set; }
    }

    public enum FunctionType 
    {
        PURE,
        VIEW
    }

    public enum DataType
    {
        uint8,
        uint256
    }
}