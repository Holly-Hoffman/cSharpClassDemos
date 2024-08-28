namespace Homework_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calulator");


            while (true) {
                Console.WriteLine();
                Console.Write("Enter length: ");
                string longness = Console.ReadLine();
                double length = double.Parse(longness);
                Console.Write("Enter width: ");
                string wideness = Console.ReadLine();
                double width = double.Parse(wideness);
                Console.WriteLine("Area = " + width * length);
                Console.WriteLine("Perimeter = " + (width += width += length += length) );

                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                string response = Console.ReadLine().ToLower();
                if (response != "y")
                { break; }

            }

        }
    }
}
