namespace EthSharp
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
        BEGIN_CONTRACT
    }
}