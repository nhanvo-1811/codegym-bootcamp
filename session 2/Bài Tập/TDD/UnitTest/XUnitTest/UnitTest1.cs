using System;
using Xunit;
using UnitTest;

namespace XUnitTest
{
    public class UnitTest1
    {
        Calcuator cal = new Calcuator();
        [Fact]
        public void TestAdd()
        {
            Assert.Equal(10, cal.Add(5, 5));
        }
        [Theory]
        [InlineData(1, 2, 3)]

        public void AddTest(int a, int b, int c)
        {
            Assert.Equal(c, cal.Add(b, a));
        }
    }
}
