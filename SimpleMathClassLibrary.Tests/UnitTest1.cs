using System;
using Xunit;
using SimpleMathClassLibrary;

namespace SimpleMathClassLibrary.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculator calc = new Calculator();

            int expected = 30;
            int actual = calc.addition(10, 20);

            Assert.Equal(expected, actual);
        }
    }
}

