namespace Homework5._3
{
    internal class Program
    {
        static int Random(int minVal, int maxVal)
        {
            return new Random().Next(minVal, maxVal);
        }

        //private string IsPresent(string choice, string name)
        //{
        //    string msg = "";
        //    if (choice == "")
        //    {
        //        msg = name + " is a required field.\n";
        //    }
        //    return msg;
        //}
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
                    int Guess = IntGuess("\nEnter number: ", 1, 100);
                    counter++;

                    if (Guess > Num + 10)
                    {
                        Console.WriteLine("Way too high! Guess again.");
                    }

                    else if (Guess > Num)
                    {
                        Console.WriteLine("Too high! Guess again.");
                    }

                    else if (Guess < Num - 10)
                    {
                        Console.WriteLine("Way too low! Guess again.");
                    }

                    else if (Guess < Num)
                    {
                        Console.WriteLine("Too low! Guess again.");
                    }

                    else
                    {
                        Console.WriteLine($"You got it in {counter} tries.");

                        if (counter <= 3)
                        {
                            Console.WriteLine("Great work! You are a mathematical wizard.");
                        }

                        else if (counter <= 7)
                        {
                            Console.WriteLine("Not too bad! You've got some potential.");
                        }

                        else
                        {
                            Console.WriteLine("What took you so long? Maybe you should take some lessons.");
                        }
                        break;
                    }
                }

                choice = GetString("\nTry again? (y/n): ", "y", "n");


            }
            Console.WriteLine("\nBye - Come back soon!");
        }

        private static int IntGuess(string prompt, int min, int max)
        {
            int number = 0;
            Boolean isValid = false;

            while (!isValid)
            {
                try
                {
                    Console.Write(prompt);
                    number = int.Parse(Console.ReadLine());
                    if (number < min)
                    {
                        Console.WriteLine($"Invalid entry: number must be greater than {min}.");
                        continue;
                    }
                    else if (number > max)
                    {
                        Console.WriteLine($"Invalid entry: number must be less than {max}.");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry: please enter a valid number.");
                    continue;
                }
            }

            return number;
        }

        private static string GetString(string prompt, string s1, string s2)
        {
            string StrVal = "";
            Boolean isValid = false;

            while (!isValid)
            {
                Console.WriteLine(prompt);
                StrVal = Console.ReadLine();

                if (StrVal == "")
                {
                    Console.WriteLine("Error! This entry is required. Try again.");
                }
                else if (StrVal != s1 && StrVal != s2)
                {
                    Console.WriteLine("Error! Entry must be 'y' or 'n'. Try again.");
                }
                else
                { break; }

            }
            return StrVal;
        }
    }
}
