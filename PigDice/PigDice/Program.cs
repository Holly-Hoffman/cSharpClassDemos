using System.Xml.Serialization;

namespace PigDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSectionHeader("Welcome to the pig dice game!!");

            string choice = "y";
            while (choice == "y")
            {
                int rollQty = GetInt("\nHow many pig pens should we roll in? ", 1, Int32.MaxValue);
                Console.WriteLine();
                PrintSectionHeader2($"Prepping {rollQty} pens...");

                int maxVal = 0;
                int rollCount = 0;

                //timing component
                DateTime start = DateTime.Now;

                for (int i = 0; i < rollQty; i++)
                {
                    int sum = 0;
                    //This is for dice
                    while (true)
                    {
                        int dieRoll = Dice(1, 7);
                        //Console.WriteLine(dieRoll);
                        sum += dieRoll;
                        rollCount++;
                        if (dieRoll == 1) { break; }

                    }

                    maxVal = Math.Max(maxVal, sum);
                }

                DateTime end = DateTime.Now;
                Console.WriteLine($"\n{rollQty} pens rolled in!");
                Console.WriteLine($"We rolled for {end - start} seconds!");
                Console.WriteLine($"Biggest pig pen had {maxVal} pips in it!");
                Console.WriteLine($"We ended up rolling {rollCount} times!\n");

                choice = GetString("Want to roll again? (y/n)");
            }
        }

        //To get dice rolls
        static int Dice(int minVal, int maxVal)
        {
            return new Random().Next(minVal, maxVal);
        }

        //GetInt - checking when user has to enter ints
        private static int GetInt(string prompt, int min, int max)
        {
            int rollQty = 0;
            Boolean isValid = false;

            while (!isValid)
            {
                try
                {
                    Console.Write(prompt);
                    rollQty = int.Parse(Console.ReadLine());
                    if (rollQty < min)
                    {
                        Console.WriteLine($"Invalid entry: number must be greater than {min}.");
                        continue;
                    }
                    else if (rollQty > max)
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

            return rollQty;
        }


        //GetString: used to grab info from user
        private static string GetString(string prompt)
        {
            PrintSectionHeader(prompt);
            return Console.ReadLine().ToLower();
        }

        //to make pretty headers
        private static void PrintSectionHeader(string sectionHeader)
        {
            Console.WriteLine(GetSeparator(sectionHeader.Length));
            Console.WriteLine(sectionHeader);
            Console.WriteLine(GetSeparator(sectionHeader.Length));
        }

        private static string GetSeparator(int length)
        {
            string separatorPattern = "(' ')";
            int totalLength = length;
            string separatorString = separatorPattern;
            while (separatorString.Length < totalLength)
            {
                separatorString += separatorPattern;
            }
            return separatorString.Substring(0, totalLength);
        }

        private static void PrintSectionHeader2(string sectionHeader2)
        {
            Console.WriteLine(GetSeparator2(sectionHeader2.Length));
            Console.WriteLine(sectionHeader2);
            Console.WriteLine(GetSeparator2(sectionHeader2.Length));
        }

        private static string GetSeparator2(int length2)
        {
            string separatorPattern2 = "#";
            int totalLength2 = length2;
            string separatorString2 = separatorPattern2;
            while (separatorString2.Length < totalLength2)
            {
                separatorString2 += separatorPattern2;
            }
            return separatorString2.Substring(0, totalLength2);
        }

    }
}
