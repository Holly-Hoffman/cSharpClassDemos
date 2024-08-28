namespace Homework4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes table!");
            string choice = "y";
            while (choice == "y")
            {
                Console.Write("\nEnter an integer: ");

                int n = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("======\t=======\t=====");

                for (int i = 1; i <= n; i++)
                {
                    int sq = i * i;
                    int cu = i * i * i;

                    Console.WriteLine($"{i}\t{sq}\t{cu}");

                }


                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }

        }
    }
}
