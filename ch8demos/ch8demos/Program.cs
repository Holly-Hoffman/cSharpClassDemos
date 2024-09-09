using System.Collections;

namespace ch8demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Chapter 8- Arrays and Collections!");

            // p. 230 One Dimensional Arrays
            // p. 231 Basic Array Demos
            string[] names = { "Sean", "Sarika", "Graydon", "Holly", "Chris", "Brendan", "Brandon", "Graham" };
            int[] numbers = new int[10];
            Console.WriteLine($"names: {names}.");
            Console.WriteLine($"numbers: {numbers}.");

            // p. 233 Assigning Values to Arrays
            // add numbers into the numbers array
            //index positions: starts at 0.  for this, goes to 9
            numbers[0] = 2;
            numbers[1] = 4;
            numbers[2] = 6;
            numbers[3] = 8;
            numbers[4] = 10;
            numbers[5] = 12;
            numbers[6] = 14;


            // Assigning and Creating at the same time
            decimal[] prices = { 25.99m, 14.25m, 9.99m, 1.49m, 99.99m };
            // p. 235 Working w/ Arrays - average, populating

            decimal sum = prices[0] + prices[1] + prices[2] + prices[3] + prices[4];
            Console.WriteLine($"Sum of prices: {sum}");
            Console.WriteLine($"Average: {sum / prices.Length}");

            //loop through numbers array, print each number, and add it to a running total
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
                Console.WriteLine($"i is {i} - numbers [{i}] = {numbers[i]}. Total is now {total}.");
            }

            // p. 237 For each loop
            //loop through names, printing each name

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //add a new name to our names array - Denise
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Names[{i}]: {names[i]}");
            }

            //add denise
            //names[8] = "Denise"; - index out of bounds exception

            // p. 239 Rectangular Arrays
            //array of arrays - like a table
            //this is going to matter at tic tac toe
            // making one of names
            string[,] namesTable = new string[9,2];
            namesTable[0, 0] = "First";
            namesTable[0, 1] = "Last";
            namesTable[1, 0] = "Sean";
            namesTable[1, 1] = "Blessing";
            namesTable[2, 0] = "Holly";
            namesTable[2, 1] = "Hoffman";
            namesTable[3, 0] = "Chris";
            namesTable[3, 1] = "Silver";
            namesTable[4, 0] = "Sarika";
            namesTable[4, 1] = "Srivastava";
            namesTable[5, 0] = "Brandon";
            namesTable[5, 1] = "Moore";
            namesTable[6, 0] = "Brendan";
            namesTable[6, 1] = "Keam";
            namesTable[7, 0] = "Graham";
            namesTable[7, 1] = "Arnett";
            namesTable[8, 0] = "Graydon";
            namesTable[8, 1] = "Kappes";

            for (int row = 0; row < namesTable.GetLength(0); row++)
            {
                for (int column = 0; column < namesTable.GetLength(1); column++)
                {
                    //Console.WriteLine($"namesTable[{i},{j}]: {namesTable[i,j]}");
                    Console.Write($"{namesTable[row, column]}\t");
                }
                Console.WriteLine();
            }

            // p. 241 Working with the Numbers Array

            // p. 243 Arrays Class
            //sorting
            Array.Sort(names);
            Console.WriteLine("Sorted names");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //finding the index position of a value
            Console.WriteLine($"Position of Graham: {Array.BinarySearch(names, "Graham")}");

            // p. 245 Reference to an Array

            // p. 247 

            // p. 249

            // p. 251 More ways to refer to Array elements

            // p. 253 List patterns

            // p. 255-257 Collections
            //257:
            ArrayList things = new ArrayList();
              things.Add(2);
            things.Add("test");

               foreach (var item in things) {
                Console.WriteLine(item);
                }

            //typed colledtion
            List<string> movieTitles = new List<string>();
            movieTitles.Add("The Shawshank Redeption");
            movieTitles.Add("Up");
            movieTitles.Add("Get Out");
            movieTitles.Add("Hamilton");

            Console.WriteLine("------------");

            foreach (string mt in movieTitles)
            {
                Console.WriteLine(mt);
            }

            Console.WriteLine("-------------");
            movieTitles.Insert(2, "Test Movie");


            foreach (string mt in movieTitles)
            {
                Console.WriteLine(mt);
            }
            Console.WriteLine("-------------");
            movieTitles.RemoveAt(2);

            foreach (string mt in movieTitles)
            {
                Console.WriteLine(mt);
            }


            // p. 259 List implementations

            // p. 261 List examples

            // p. 263 Create and load a sorted list

            // p. 265 Looking up values based on key

            // p. 267 Queues

            // p. 269 Using ArrayLists

            Console.WriteLine("Bye");

        }
    }
}
