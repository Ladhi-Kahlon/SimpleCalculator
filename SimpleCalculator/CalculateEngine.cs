using System;

namespace SimpleCalculator
{
    class CalculateEngine
    {
        public double Calculate(string argOperation, double numValue1, double numValue2)
        {
            double resultValue;

            switch (argOperation.ToLower())
            {
                case "+" :
                    resultValue = numValue1 + numValue2;
                    break;
                case "-":
                    resultValue = numValue1 - numValue2;
                    break;
                case "*":
                    resultValue = numValue1 * numValue2;
                    break;
                case "/":              
                    resultValue = numValue2 == 0 ? 0 : numValue1 / numValue2;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized");
            }

            return resultValue;
        }
    }
}
