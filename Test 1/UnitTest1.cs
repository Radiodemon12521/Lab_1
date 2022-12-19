using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_1.Operations;

namespace Test_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var num = new Divide();
            var sum = num.Calculate(5, 8);
            Assert.AreEqual(0.625, sum);

        }
        [TestMethod]
        public void TestMethod2()
        {
            var num = new Multiply();
            var sum = num.Calculate(5, 8);
            Assert.AreEqual(40, sum);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var num = new Minus();
            var sum = num.Calculate(5, 8);
            Assert.AreEqual(-3, sum);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var num = new Plus();
            var sum = num.Calculate(5, 8);
            Assert.AreEqual(13, sum);
        }
    }
}