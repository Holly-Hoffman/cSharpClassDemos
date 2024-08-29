using System.ComponentModel.Design.Serialization;

namespace Homework5._1
{
    internal class Program
    {
        static int Dice(int minVal, int maxVal)
        {
            return new Random().Next(minVal, maxVal);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dice Roller");
            Console.Write("\nRoll the dice? (y/n): ");
            string choice = Console.ReadLine().ToLower();

            while (choice == "y")
            {
                int D1 = Dice(1, 7);
                int D2 = Dice(1, 7);
                int Tot = D1 + D2;
                Console.WriteLine($"\nDie 1: {D1}");
                Console.WriteLine($"Die 2: {D2}");
                Console.WriteLine($"Total: {Tot}");
                if (Tot == 2)
                {
                    Console.WriteLine("Snake eyes!");
                    Console.WriteLine();
                }
                else if (Tot == 12)
                {
                    Console.WriteLine("Boxcars!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                }
                Console.Write("Roll again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }

        }
    }
}
