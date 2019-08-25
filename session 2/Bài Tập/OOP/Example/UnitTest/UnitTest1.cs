using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example.Ex1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Person per = new Person();
        Student te = new Student();
        [TestMethod]
        public void TestMethod1()
        {
            per.SetAge(20);
            Assert.IsNotNull(per.GetAge());
            //Assert.IsNotNull(te.Explain());
        }
    }
}
