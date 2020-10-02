using System;
using System.Text;
using Xunit;

namespace esharp.transpiler.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Should_Traspile_Empty_Contract()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[Contract]");
            sb.AppendLine("public class Greeter");
            sb.AppendLine("{");
            sb.AppendLine();
            sb.AppendLine("}");
        }
    }
}
