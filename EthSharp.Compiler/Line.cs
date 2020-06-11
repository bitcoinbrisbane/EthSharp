using System;

namespace EthSharp.Compiler
{
    public class Line
    {
        public string Data { get; set; }

        public Int32 Number { get; set; }

        public LineType LineType { get; set; }

        public Line()
        {
        }

        public Line(string data)
        {
            Data = data;
        }
    }

    public enum LineType
    {
        PRAGMA,
        BEGIN_CONTRACT,

        BEGIN_STRUCT,

        BEGIN_FUNCTION,

        END,

        END_CONTRACT,

        END_FUNCTION,

        WHITE_SPACE
    }
}