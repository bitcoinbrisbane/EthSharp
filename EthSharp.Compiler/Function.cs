using System;

namespace EthSharp.Compiler
{
    public class Function
    {
        public String Name { get; set; }

        public String Access { get; set; }

        public DataType DataType { get; set; }
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