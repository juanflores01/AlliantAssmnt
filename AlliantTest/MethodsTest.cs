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
            ITerminal terminal = new ITerminal();
            var costTotal = terminal.Terminal(userInput);
            var expectedPrice = 32.40m;

            Assert.IsTrue(costTotal == expectedPrice);
        }

        [TestMethod]
        public void TestMethod_CCCCCCC()
        {
            var userInput = "CCCCCCC";
            ITerminal terminal = new ITerminal();
            var costTotal = terminal.Terminal(userInput);
            var expectedPrice = 7.25m;

            Assert.IsTrue(costTotal == expectedPrice);
        }

        [TestMethod]
        public void TestMethod_ABCD()
        {
            var userInput = "ABCD";
            ITerminal terminal = new ITerminal();
            var costTotal = terminal.Terminal(userInput);
            var expectedPrice = 15.40m;

            Assert.IsTrue(costTotal == expectedPrice);
        }
    }
}
