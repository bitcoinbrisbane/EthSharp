using System;
using System.Collections;
using System.IO;
using Xunit;

namespace EthSharp.Compiler.Tests
{
    public class CompilerTests
    {
        [Fact]
        public void Should_Compile_Contract()
        {
            Compiler c = new Compiler();
            Boolean actual = c.Compile("Adder.sol");

            Assert.Equal(true, actual);
        }

        [Fact]
        public void Should_Get_All_Contract_Lines()
        {
            Compiler c = new Compiler();
            c.Compile("Adder.sol");

            Assert.Equal(8, c.Lines.Count);
        }

        [Fact]
        public void Should_Get_Contract_Start_Line()
        {
            Compiler c = new Compiler();
            c.Compile("Adder.sol");

            Assert.NotNull(c.Contract);
            Assert.Equal(3, c.Contract.StartLineNumber);
        }

        [Fact]
        public void Should_Get_Contract_Name()
        {
            Compiler c = new Compiler();
            c.Compile("Adder.sol");

            Assert.NotNull(c.Contract);
            Assert.Equal("Adder", c.Contract.Name);
        }
    }
}
