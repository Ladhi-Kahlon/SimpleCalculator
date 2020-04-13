using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.MSUnit
{
    [TestClass]
    class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertInputStringIntoDecimal()
        {
            string input = "99";
            double result = _inputConverter.ToDouble(input);

            Assert.AreEqual(99, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestArgumentNullException()
        {
            string input = string.Empty;
            _inputConverter.ToDouble(input);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestArgumentException()
        {
            string input = "x";
            _inputConverter.ToDouble(input);
        }

    }
}
