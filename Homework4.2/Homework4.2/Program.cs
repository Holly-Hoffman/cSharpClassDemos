namespace Homework4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator!");

            string choice = "y";
            while (choice == "y") {
                Console.WriteLine();
                Console.Write("Enter an integer that's greater than 0 and less than 10: ");
                int nbr = int.Parse(Console.ReadLine());

                int f = 1;

                for (int i = 1; i <= nbr; i++) {
                    f *=i;
                }
                Console.WriteLine($"The factorial of {nbr} is {f}.");
                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();




            }
        }
    }
}
