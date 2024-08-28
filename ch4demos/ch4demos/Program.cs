namespace ch4demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Chapter 4 Demos!");

            //Constants (pg 96)
            const int DaysInNovember = 30;
            //Most people do it like
            const int DAYS_IN_WEEK = 7;
            //Must definie and initialize the constant on the same line

            // Binary operators require two variables pg 97
            int a = 5;
            int b = 12;
            int c = a + b;

            int d = b - a;

            int e = b / a;
            
            int f = b % a;

            //string interpolation: this is like concatinating? pg 288
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");
            Console.WriteLine($"e = {e}");
            Console.WriteLine($"f = {f}");

            //doubles
            double g = 13;
            double h = 5;
            double i = g / h;

            Console.WriteLine($"i = {i}");




            // Unary operators only need one variable pg 98
            int count = 0;
            Console.WriteLine($"Count: {count}");
            count++;
            Console.WriteLine($"Count: {count}");

            // Compound assignment operators pg 101
            count += 5;
            Console.WriteLine($"Count: {count}");
            count -= 2;
            Console.WriteLine($"Count: {count}");
            count = count + 10;
            Console.WriteLine($"Count: {count}");

            // Math class pg 107
            //round()
            double interestRate = .078453;
            Console.WriteLine($"Interest Rate: {interestRate}");
            double smolRate = Math.Round(interestRate, 2);
            Console.WriteLine($"Interest Rate: {smolRate}");
            double midRate = Math.Round(interestRate, 4);
            Console.WriteLine($"Interest Rate: {midRate}");



            // Formatting pg 121
            //Format as percentage
            Console.WriteLine($"Interest Rate - formatted: {midRate.ToString("p1")}"); //1 decimal percent
            Console.WriteLine($"Interest Rate - formatted: {midRate.ToString("p2")}"); //2 decimal percent

            //format currency
            decimal price1 = 34.99M;
            Console.WriteLine($"Price1: {price1}");
            Console.WriteLine($"Price1: - formatted: " +
                $"{price1.ToString("c")}");





        }
    }
}
