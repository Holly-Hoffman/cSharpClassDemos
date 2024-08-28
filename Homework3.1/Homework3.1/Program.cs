namespace Homework3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter");


            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine();
                Console.Write("Enter degrees in Fahrenheit: ");
                decimal fDegrees = decimal.Parse(Console.ReadLine());
                decimal cFormula = fDegrees - 32;
               // Console.WriteLine($"{cFormula}");
                decimal f = 5;
                decimal n = 9;
                decimal cFraction = f / n;
               // Console.WriteLine($"{cFraction}");
                decimal cDegrees = cFormula * cFraction;
                decimal cFinal = Math.Round(cDegrees, 2);
                //Console.WriteLine($"{cDegrees}");
                Console.WriteLine($"Degrees in Celsius: {cFinal}");

                Console.WriteLine();
                Console.Write("Continue?  (y/n): ");
                choice = Console.ReadLine().ToLower();
            }
        }
    }
}
