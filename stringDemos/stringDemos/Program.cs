namespace stringDemos
{
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "anyone WHO takes more THAN thirty minutes for lunch is UNPROFESSIONAL!";
            Console.WriteLine(original);

            string lower = original.ToLower();
            Console.WriteLine(lower);

            string firstCap = lower.Substring(0, 1).ToUpper();
            string lowRest = lower.Substring(1);
            string sentence = firstCap + lowRest;
            Console.WriteLine(sentence);

            sentence = sentence.Replace("thirty", "sixty");
            Console.WriteLine(sentence);

            string minutes = "fourty";
            Console.WriteLine($"Anyone who takes more than {minutes} minutes for lunch is unprofessional!");
            //or
            sentence = sentence.Replace("sixty", minutes);
            Console.WriteLine(sentence);
            //or
            string complete = original.Substring(0, 1).ToUpper() + original.Substring(1).ToLower().Replace("thirty", "fourty");
            Console.WriteLine(complete);

            decimal number = 123_555;
            Console.WriteLine(number);

            DateTime start = DateTime.Now;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10000; i++)
            {
                sb.Append("0123456789");
            }

            DateTime end = DateTime.Now;

            Console.WriteLine(end - start);

            decimal theNumber = 123216354984.51564988M;
            // with commas and 3 decimals
            Console.WriteLine($"The value is {theNumber:N3}");

            //as dollars
            Console.WriteLine($"The value is {theNumber:C}");
            //or
            Console.WriteLine($"The value is ${theNumber:N2}");

            //this is what we are doing in the back end.  It is not used often anymore
            string prettynumber = String.Format("The price is ${0:N2}.", theNumber);
            Console.WriteLine(prettynumber);

            //to add spaces before to line things up, can do "The price is ${theNumber},20,N
            Console.WriteLine($"The value is ${theNumber,20:N}");


        }
    }
}
