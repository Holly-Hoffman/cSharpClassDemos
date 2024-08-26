using System.Diagnostics.Metrics;

namespace Demo01StringsInts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Strings and Ints Demo!");

            //This is a single line comment

            /*This
             * is
             * a
             * multi
             * line
             * comment
             */

            //From chapter 4

            //thisIsCamelCase - used for local variables
            //PascalCase or TitleCase - used for method names and properties
            //this-is-spinal-case - used in angular
            //this_is_snake_case

            
            int counter = 1;

            Console.WriteLine("Counter is " + counter);

            double price = 32.99;
            int units = 5;
            double lineTotal = price * units;
            double lineTotalRounded = Math.Round(lineTotal, 2);
            Console.WriteLine("Price * units = " + lineTotal);
            Console.WriteLine("lineTotalRounded = " + lineTotalRounded);

            //decimal instead
            decimal price2 = 32.99M;
            decimal lineTotal2 = price2 * units;
            Console.WriteLine("lineTotal2 = " + lineTotal2);

            //string literal
            string helloString = "Hello, ";

            //string from user input
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            //printing it out
            Console.WriteLine(helloString + name);

            //get numbers from console
            Console.WriteLine("=================");
            Console.Write("Enter a whole number: ");
            int nbr1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a decimal number: ");
            double nbr2 = Double.Parse(Console.ReadLine());
            double product1 = nbr1 * nbr2;
            Console.WriteLine("product1 = " + product1);
            

            Console.WriteLine("If Else Statements!");
            //if nbr1 > 10, print "greater than 10", else if nbr1 <0, print "less than 0", else print "Between 0 and 10"
            if (nbr1 > 10)
            {
                Console.WriteLine("Greater than 10!");
            }
            else if (nbr1 < 0)
            {
                Console.WriteLine("Less than 0!");
            }
            else
            {
                Console.WriteLine("Between 0 and 10!");
            }

            //continue until user enters "n"
            Console.WriteLine("While Loops!  Like Froot Loops, but whiley!");

          
            string choice = "";
            while ( choice.ToLower() != "n" )
            {
                Console.WriteLine("You entered :"+choice);
                Console.Write("Do you want to continue? (y/n): ");
                choice = Console.ReadLine();
            }



            Console.WriteLine("Bye!");

        }
    }
}
