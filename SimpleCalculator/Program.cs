using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endCalc = false;
            Console.WriteLine("Simple Calculator App:");

            while (!endCalc)
            {
                try
                {
                    InputConverter converter = new InputConverter();
                    CalculateEngine calEngine = new CalculateEngine();

                    Console.Write("Enter First Value: ");
                    double firstParam = converter.ToDouble(Console.ReadLine());
                    Console.Write("Enter Second Value: ");
                    double secondParam = converter.ToDouble(Console.ReadLine());
                    Console.Write("Enter Operation \"+\", \"-\", \"*\" or \"/\": ");
                    string operation = Console.ReadLine();
                    double result = calEngine.Calculate(operation, firstParam, secondParam);

                    Console.WriteLine("\n");
                    Console.WriteLine(@"Result for {0} {1} {2} = {3}", firstParam.ToString(), operation, secondParam.ToString(), result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Enter n to Exit Application");
                if (Console.ReadLine().ToLower() == "n")
                {
                    endCalc = true;
                    break;
                }
            }

            Console.WriteLine("Thank You, press any key to exit application");
            Console.ReadKey();
        }
    }
}
