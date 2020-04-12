using System;

namespace SimpleCalculator
{
    class InputConverter
    {
        public double ToDouble(string inputValue)
        {
            double returnValue;

            if (string.IsNullOrEmpty(inputValue))
            {
                throw new ArgumentNullException("Input value required");
            }

            if (!double.TryParse(inputValue, out returnValue))
            {
                throw new ArgumentException("Expected a numeric value");
            }

            return returnValue;
        }
    }
}
