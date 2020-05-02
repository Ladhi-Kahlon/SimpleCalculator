using System;

namespace SimpleCalculator
{
    public class MathOperDesc
    {
        public string TypeDescription(string inputValue)
        {
            switch (inputValue)
            {
                case "+":
                    return "Add";
                case "-":
                    return "Subtract";
                case "/":
                    return "Divide";
                case "*":
                    return "Multiply";
                default:
                    throw new InvalidOperationException("Invalid Operation Symbol");
            }
        }
    }
}
