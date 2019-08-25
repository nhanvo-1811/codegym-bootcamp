using NUnit.Framework;
using UnitTest;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private Calcuator _Cal;
        [SetUp]

        public void Setup()
        {

            _Cal = new Calcuator();
        }

        [Test]
        public void AddTest()
        {
            Assert.AreEqual(20, _Cal.Add(10, 10));
        }
        [TestCase(20, 9,11)]
        public void testadd(int a, int b, int c)
        {
            Assert.AreEqual(a, _Cal.Add(b,c));
        }
    }
}