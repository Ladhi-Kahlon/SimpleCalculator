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
            int num1 = 1;
            int num2 = 2;
            string opr = "+";

            double result = _calEngine.Calculate(opr, num1, num2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestExpectedException()
        {
            int num1 = 1;
            int num2 = 2;
            string opr = "&&";

            _calEngine.Calculate(opr, num1, num2);
        }
    }
}
