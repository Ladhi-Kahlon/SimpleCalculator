using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ToDouble(string inputValue)
        {
            if (string.IsNullOrEmpty(inputValue))
            {
                throw new ArgumentNullException(nameof(inputValue));
            }

            if (!double.TryParse(inputValue, out var returnValue))
            {
                throw new ArgumentException("Expected a numeric value");
            }

            return returnValue;
        }
    }
}
