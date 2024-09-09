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
            string choice = GetString("\nRoll the dice? (y/n: ");

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

                choice = GetString("Roll again? (y/n): ");
            }

        }

        private static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }
    }
}
