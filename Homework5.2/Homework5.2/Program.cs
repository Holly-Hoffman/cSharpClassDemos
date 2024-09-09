namespace Homework5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //need to validate choice as y or n and not empty
            Console.WriteLine("Welcome to the data validator app!");
            const double MinDoub = 1;
            const double MaxDoub = 1000;

            string choice = "y";
            while (choice == "y")
            {
                Console.Write("\nEnter lenth: ");
                Console.Write("Enter width: ");
                double length = GetDouble("Enter length: ", MinDoub, MaxDoub);
                double width = GetDouble("Enter width: ", MinDoub, MaxDoub);

                double area = length * width;
                double perimeter = 2 * length + 2 * width;

                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");

                choice = GetString("\nContinue? (y/n) ", "y", "n");
            }

        }

        //Get a required string (empty value not accepted) that is either s1 or s2
        private static string GetString(string prompt, string s1, string s2) {
            string StrVal = "";

            Boolean isValid = false;

            while (!isValid)
            {
                Console.WriteLine(prompt);
                StrVal = Console.ReadLine().ToLower();
                if (StrVal == "")
                {
                    Console.WriteLine("Error! This entry is required.  Try again.");
                }
                else if (StrVal != s1 && StrVal != s2)
                {
                    Console.WriteLine("Error! Entry must be 'y' or 'n'.  Try again.");
                }
                else
                {
                    break;
                }
            }

            return StrVal;
        }

        private static double GetDouble(string prompt, double min, double max)
        {
            double number = 0.0;
            Boolean isValid = false;

            while (!isValid)
            {
                Console.Write(prompt);
                try
                {
                    number = Double.Parse(Console.ReadLine());
                    if (number < min)
                    {
                        Console.WriteLine($"Error! Number must be greater than {min}");
                    }
                    else if (number > max)
                    {
                        Console.WriteLine($"Error! Number must be less than {max}");
                    }

                    else { break; }
                }

                catch (Exception e) {
                    Console.WriteLine("Invalid decimal value. Try again.");
                    continue;
                }
            }

            return number;
        }

    }
}
