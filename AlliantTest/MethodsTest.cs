using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlliantLibrary;

namespace AlliantTest
{
    [TestClass]
    public class MethodsTest
    {
        [TestMethod]
        public void TestMethod_ABCDABAA()
        {
            var userInput = "ABCDABAA";
            Methods methods = new Methods();
            var costTotal = methods.Terminal(userInput);
            var expectedPrice = 32.40m;

            Assert.IsTrue(costTotal == expectedPrice);
        }

        [TestMethod]
        public void TestMethod_CCCCCCC()
        {
            var userInput = "CCCCCCC";
            Methods methods = new Methods();
            var costTotal = methods.Terminal(userInput);
            var expectedPrice = 7.25m;

            Assert.IsTrue(costTotal == expectedPrice);
        }

        [TestMethod]
        public void TestMethod_ABCD()
        {
            var userInput = "ABCD";
            Methods methods = new Methods();
            var costTotal = methods.Terminal(userInput);
            var expectedPrice = 15.40m;

            Assert.IsTrue(costTotal == expectedPrice);
        }
    }
}
