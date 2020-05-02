using System;
using System.Globalization;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator App:");

            while (true)
            {
                try
                {
                    var converter = new InputConverter();
                    var calEngine = new CalculateEngine();
                    Console.WriteLine("\n");

                    Console.Write("Enter First Value: ");
                    var firstParam = converter.ToDouble(Console.ReadLine());
                    Console.Write("Enter Second Value: ");
                    var secondParam = converter.ToDouble(Console.ReadLine());
                    Console.Write("Enter Operation \"+\", \"-\", \"*\" or \"/\": ");
                    var operation = Console.ReadLine();
                    var result = calEngine.Calculate(operation, firstParam, secondParam);
                   
                    Console.WriteLine(@"Result for {0} {1} {2} = {3}", firstParam.ToString(CultureInfo.InvariantCulture), operation, secondParam.ToString(CultureInfo.InvariantCulture), result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                Console.WriteLine("Enter n to Exit Application");
                if (Console.ReadLine()?.ToLower() != "n") continue;
                break;
            }

            Console.WriteLine("Thank You!");
            //Console.ReadKey();
        }

        //bool continueProgram = true;
        //do
        //{
        //    //do something 
        //    Console.WriteLine("Welcome Message");
        //    //Check if user want to continue (Required answer Y for Yes and N for No
        //    string contintueProgramDecision = string.Empty;
        //    do
        //    {
        //        Console.Write("Do you wat to continue? Y/N: ");
        //        contintueProgramDecision = Console.ReadLine() ?? string.Empty;

        //    } while (!contintueProgramDecision.Equals("Y", StringComparison.OrdinalIgnoreCase)
        //            && !contintueProgramDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

        //    continueProgram = contintueProgramDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

        //} while (continueProgram);
    }
}
