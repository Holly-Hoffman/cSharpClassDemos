namespace Homework5._3
{
    internal class Program
    {
        static int Random(int minVal, int maxVal)
        {
            return new Random().Next(minVal, maxVal);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guess the Number Game!");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");

            string choice = "y";
            while (choice == "y")
            {

                Console.WriteLine("\nI'm thinking of a number from 1 to 100. \nTry to guess it.");
                int Num = Random(1, 101);

                int counter = 0;


                while (true)
                {
                    Console.Write("\nEnter number: ");
                    int Guess = int.Parse(Console.ReadLine());

                    if (Guess > Num + 10)
                    {
                        Console.WriteLine("Way too high! Guess again.");
                        counter++;
                    }

                    else if (Guess > Num)
                    {
                        Console.WriteLine("Too high! Guess again.");
                        counter++;
                    }

                    else if (Guess < Num - 10)
                    {
                        Console.WriteLine("Way too low! Guess again.");
                        counter++;
                    }

                    else if (Guess < Num)
                    {
                        Console.WriteLine("Too low! Guess again.");
                        counter++;
                    }

                    else { break; }
                }

                Console.WriteLine($"You got it in {counter} tries.");

                if (counter <= 3)
                {
                    Console.WriteLine("Great work!  You are a mathematical wizard.");
                }

                else if (counter <= 7)
                {
                    Console.WriteLine("Not too bad! You've got some potential.");
                }

                else
                {
                    Console.WriteLine("What took you so long? Maybe you should take some lessons.");
                }

                Console.Write("\nTry again? (y/n): ");
                choice = Console.ReadLine();


            }
            Console.WriteLine("\nBye - Come back soon!");
        }
    }
}
