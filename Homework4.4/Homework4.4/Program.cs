

namespace Homework4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Common Divisor App!");

            string choice = "y";
            while (choice == "y")
            {
                Console.Write("\nEnter first number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int y = int.Parse(Console.ReadLine());
                
                //if (x > y)
                //{
                //    int OGX = x;
                //    x = y;
                //    y = OGX;
                //}

                //Console.WriteLine($"first, x is {x}, y is {y}");
                
                while (x != 0)
                {
                    //Console.WriteLine($"second, x is {x}, y is {y}");

                    while (y >= x)
                    {
                        //Console.WriteLine($"third, x is {x}, y is {y}");
                        y = y - x;
                        //could also write as y -= x;
                        //Console.WriteLine($"fourth, x is {x}, y is {y}");
                    }

                    int newX = y;
                    y = x;
                    x = newX;
                   // Console.WriteLine($"fifth, x is {x}, y is {y}");
                }

                Console.WriteLine($"{y} is common greatest divisor");


                //compare x and y
                //make the lower # x
                // 1) subtract x from y until y < x (while loop)
                // 2) swap x and y
                //repeat 1 and 2 until x = 0
                // when x = 0, y is greatest common denominator

                //print greatest common denom


                Console.Write("\n Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }
            }
        }
    }
