using System;
using System.Collections.Generic;
using System.Text;

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
                    return "Substract";
                case "/":
                    return "Divide";
                case "*":
                    return "Mutliply";
                default:
                    throw new InvalidOperationException("Invalid Operation Symbol");
            }
        }
    }
}
