using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlliantLibrary;

namespace AlliantTest
{
    [TestClass]
    public class MethodsTest
    {
        public decimal Terminal(string userInput)
        {
            Methods methods = new Methods();
            var list = methods.Scan(userInput);
            var costTotal = methods.Total(list);

            return costTotal;
        }

        [TestMethod]
        public void TestMethod_ABCDABAA()
        {
            var userInput = "ABCDABAA";
            var costTotal = Terminal(userInput);
            var expectedPrice = 32.40m;

            Assert.IsTrue(costTotal == expectedPrice);
        }

        [TestMethod]
        public void TestMethod_CCCCCCC()
        {
            var userInput = "CCCCCCC";
            var costTotal = Terminal(userInput);
            var expectedPrice = 7.25m;

            Assert.IsTrue(costTotal == expectedPrice);
        }

        [TestMethod]
        public void TestMethod_ABCD()
        {
            var userInput = "ABCD";
            var costTotal = Terminal(userInput);
            var expectedPrice = 15.40m;

            Assert.IsTrue(costTotal == expectedPrice);
        }
    }
}
