using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.MSUnit
{
    [TestClass]
    public class CalculateEngineTest
    {
        private readonly CalculateEngine _calEngine = new CalculateEngine();

        [TestMethod]
        public void TestCalculateEngineMethod()
        {
            const int num1 = 1;
            const int num2 = 2;
            const string opr = "+";

            var result = _calEngine.Calculate(opr, num1, num2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestExpectedException()
        {
            const int num1 = 1;
            const int num2 = 2;
            const string opr = "&&";

            _calEngine.Calculate(opr, num1, num2);
        }
    }
}
