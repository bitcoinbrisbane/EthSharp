using System;
using System.Collections;
using System.IO;
using Xunit;

namespace EthSharp.Compiler.Tests
{
    public class CompilerTests
    {
        [Fact]
        public void Should_Get_Pragma()
        {
            Compiler c = new Compiler();
            c.Compile("Adder.sol");

            Assert.Equal(7, c.Lines.Count);
        }
    }
}
