namespace _5._1SB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dice Roller!");
            const int max_val = 7;

            string RollDice = GetString("Roll the dice (y/n)? ");
            while (RollDice == "y")
            {
                int d1 = GetDie(max_val);
                int d2 = GetDie(max_val);
                int sum = d1 + d2;

                Console.WriteLine($"\nDie 1: {d1}\nDie 2: {d2}\nTotal: {sum}");

                if (sum == 2) { Console.WriteLine("Snake eyes!"); }
                else if (sum == 12)
                {
                    Console.WriteLine("Boxcars!");
                }
                Console.WriteLine();

                RollDice = GetString("Roll again (y/n)? ");
            }
        }

        private static int GetDie(int maxVal)
        {
            return new Random().Next(1, maxVal);
        }

        private static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }
    }
}
