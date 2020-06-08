namespace EthSharp.Compiler
{
    public class Line
    {
        public string Data { get; set; }

        public int Number { get; set; }

        public LineType LineType { get; set; }
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