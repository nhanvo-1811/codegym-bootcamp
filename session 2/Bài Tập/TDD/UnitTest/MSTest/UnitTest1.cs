using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using UnitTest;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        private Calcuator cal = new Calcuator();
        private Array arrtest = new Array();
        //[TestMethod]
        public void AddTest()
        {
            Assert.IsTrue(cal.Add(1, 1) == 2);
            Assert.AreEqual(5, cal.Add(3, 2));
            Assert.AreEqual(10, cal.Add(3,7));
        }
        public void subTest()
        {

        }
        [TestMethod]
        public void arrTest()
        {
            int[,] arr =
            {
                {1,2 },
                {3,2 },
                {4,5 }
            };

            Assert.AreEqual(17, arrtest.SumArray(arr));
        }
    }
}
