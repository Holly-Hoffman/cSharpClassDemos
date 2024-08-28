namespace Homework3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Change Calculator!");

            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine();
                Console.Write("Enter number of cents (0-99): ");
                int cents = int.Parse(Console.ReadLine());

                int quarters = cents / 25;
                int qRemainder = cents % 25;
                int dimes = qRemainder / 10;
                int dRemainder = qRemainder % 10;
                int nickles = dRemainder / 5;
                int pennies = dRemainder % 5;

                Console.WriteLine();
                Console.WriteLine($"Quarters: {quarters}");
                Console.WriteLine($"Dimes: {dimes}");
                Console.WriteLine($"Nickles: {nickles}");
                Console.WriteLine($"Pennies: {pennies}");

                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();



            }

        }
    }
}
