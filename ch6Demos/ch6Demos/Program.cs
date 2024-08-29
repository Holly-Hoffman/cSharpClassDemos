namespace ch6Demos
{
    internal class Program
    {
        static private void PrintHello()
        {
            Console.WriteLine("Hello from PrintHello method.");
            // no params and no return void and ()
        }

        static private void PrintHello(string name)
        {
            Console.WriteLine($"Hello, {name}. Welcome to our application." +
                $"");
        }
        // one param and no return


        //prompt user for whole #
        static private int PromptInt(string prompt)
        {
            int wholeNumber = 0;
            //using while true with a break
            while (true)
            {
                //try catch statement
                try
                {
                    Console.Write(prompt);
                    wholeNumber = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    //Console.Error.WriteLine(e.ToString()); < this shows the actual issue
                    Console.WriteLine("Fool of a Took. I asked for an integer.");
                }
            }
            return wholeNumber;
        }
        // one param and return an int

        static private int PromptPositiveInt(string prompt)
        {
            int wholeNumber = 0;
            while (true)
            {
                wholeNumber = PromptInt(prompt);
                if (wholeNumber < 0)
                {
                    Console.WriteLine("I am positive you've made a mistake, HINT HINT.");
                }
                else { break; }
            }
            return wholeNumber;

        }

        static private int PromptInt(string prompt, int minVal, int maxVal) 
        {
            int wholeNumber = 0;
            Boolean validEntry = false;
            while (!validEntry)
            {
                wholeNumber = PromptInt(prompt);
                if (wholeNumber < minVal)
                {
                    Console.WriteLine($"Error: Number is less than minimum value {minVal}.");

                }
                else if (wholeNumber > maxVal)
                {
                    Console.WriteLine($"Error: Number is greater than maximum value {maxVal}.");
                }
                else
                {
                    validEntry = true;
                }
                
            }
            return wholeNumber;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Chapter 6 Demos!");

            // p. 171 Coding a method

            // calling a method to print to the console
            PrintHello();

            PrintHello("Otus");
            PrintHello("Siri");
            PrintHello("Alurah");
            PrintHello("Amanita");
            PrintHello("Ryne");
            int number1 = PromptInt("Enter number 1: ", 1, 100);
            int number2 = PromptInt("Enter number 2: ", 1, 100);
            Console.WriteLine($"Sum = {number1 + number2}");


            // three params and return a decimal

            // p. 173 Calling a Method

            // p. 175 Optional Params

            // p. 177 Replacing Code w/ a Method via Refactor

            // p. 181 ref Keyword
            int a = 1;
            Console.WriteLine($"a = {a}");
            Console.WriteLine("Calling incrementNumber...");
            incrementNumber(ref a);
            Console.WriteLine($"a = {a}");

            // p. 183 out, in Keywords

            // p. 185 Tuples, p. 187 more on Tuples
            // without tuples, define a movie.

            string title = "Oh god please help";
            int year = 2020;
            string rating = "PG";
            string director = "Steve West";

            //define a movie tuple - 184 now, apparently
            var myMovie = (title, year, rating, director);
            Console.WriteLine(myMovie);
            Console.WriteLine($"Title = {myMovie.title}");
            Console.WriteLine($"year = {myMovie.year}");

            // p. 189 - skip the rest
            //generaTE 100randomnumbers 1-100
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Random int: {generateRandom(1, 101)}");
            }





            Console.WriteLine("Bye");
        }


        private static void incrementNumber(ref int number)
        {
            Console.WriteLine("Inside of inc num");
            number++;
            Console.WriteLine($"after inc num is {number}.");
        }

        private static int generateRandom(int minVal, int maxVal)
        {
            return new Random().Next(minVal, maxVal);
            

        }
    }
}
