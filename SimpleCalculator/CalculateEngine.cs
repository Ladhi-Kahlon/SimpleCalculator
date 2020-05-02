using System;

namespace SimpleCalculator
{
    public class CalculateEngine
    {
        public double Calculate(string argOperation, double numValue1, double numValue2)
        {
            const double tolerance = 0;
            var resultValue = argOperation.ToLower() switch
            {
                "+" => numValue1 + numValue2,
                "-" => numValue1 - numValue2,
                "*" => numValue1 * numValue2,
                "/" => Math.Abs(numValue2) < tolerance ? 0 : numValue1 / numValue2,
                _ => throw new InvalidOperationException("Specified operation is not recognized")
            };

            return resultValue;
        }
    }
}
