using System.Security.Cryptography;

namespace ch18Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The legends of LINQ");

            //pg 581

            int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //seeing them all
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //even numbers
            foreach (int number in numbers)
            {
                if (number%2 == 0)
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //odd numbers reversed
            for (int i = numbers.Length -1; i>=0; i--)
            {
                if (numbers[i] % 2 != 0)
                    Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();



            Console.WriteLine("========= LINQ Queries ==========");

            //list of numbers using LINQ:

            var numberList = from number in numbers
                             select number;

            //seeing them all using LINQ
            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            //even numbers using LINQ
            numberList = from number in numbers
                             where number % 2 == 0
                             select number;
            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();



            //odd numbers reversed using LINQ
            numberList = from number in numbers
                         where number%2!=0
                         orderby number descending
                         select number;

            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();


            //pg.583 - array of decimal values
            decimal[] salesTotals = new decimal[] { 1286.45m, 2433.49m, 2893.85m, 2094.53m };

            var salesList = from sales in salesTotals
                            select sales;

            decimal sum = 0;
            foreach (var sale in salesTotals) { sum += sale; }
            Console.WriteLine($"sum = {sum}");

            salesList = from sales in salesTotals
                        where sales > 2000
                        select sales;
            string salesDisplay = "";
            foreach (var sale in salesList) { salesDisplay += sale.ToString("c") + " "; }
            Console.WriteLine($"salesDisplay = {salesDisplay}");


            Console.WriteLine("Byeaaahhh!");
        }
    }
}
