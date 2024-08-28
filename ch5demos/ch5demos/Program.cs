using System.ComponentModel.Design;

namespace ch5demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Chapter 5 demos!");

            //// p. 139 Relational Operators: what you put into while, if/else, for, etc.
            ////Typically boolean - ==, !=, >, etc.

            //string choice = "y";
            //while (choice == "y")
            //{
            //    Console.WriteLine("In while loop...");
            //    choice = "w";
            //}

            //int a = 10;
            //Console.WriteLine($"a != 10? {a! - 10}");

            //// p. 141 Logical Operators - && (evaluate until fail), & (evaluate all), || (or), |, !
            //string lightColor = "Green";
            //Boolean pedestrianInCrosswalk = true;

            //if (lightColor == "Green" & !pedestrianInCrosswalk)
            //{
            //    Console.WriteLine("go");
            //}
            //else
            //{
            //    Console.WriteLine("stop");
            //}

            //if (lightColor == "Green" && !pedestrianInCrosswalk)
            //{
            //    Console.WriteLine("go");
            //}
            //else
            //{
            //    Console.WriteLine("stop");
            //}

            //// 2 things make sean happy - ice cream and payday

            //Boolean iceCream = false;
            //Boolean payDay = true;
            //if (iceCream && payDay)
            //{
            //    Console.WriteLine("double win");
            //}
            //else if (iceCream || payDay)
            //{
            //    Console.WriteLine("one out of two, not bad");
            //}

            // p. 143 If-Else Statements
            // nested traffic light
            //red - stop, yellow - slow, green - go
            //distance to light > 30 = slow, < 30 = speed

            //lightColor = "Green";
            //int distanceToLight = 28;

            //if (lightColor == "red")
            //{
            //    Console.WriteLine("Stop");
            //}
            //else if (lightColor == "yellow")
            //{
            //    Console.WriteLine("light is yellow");
            //    if (distanceToLight > 30)
            //    {
            //        Console.WriteLine("stop");
            //    }
            //    else
            //    {
            //        Console.WriteLine("speed up");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("go")
            //}



            // p. 145 Switch Statements
            //has evolved and is used a lot now
            //could be used in games a la choose your own adventure

            //Console.WriteLine("Scary Adventure Game Options!");
            //Console.WriteLine("You're at the end of a long corridor.");
            //Console.WriteLine("There are 3 doors.  Which do you choose?");
            //Console.WriteLine("1: to the right - a red door with a skull and crossbones.");
            //Console.WriteLine("2: to the left - a blue door with a snake.");
            //Console.WriteLine("3: straight - a purple door with daisies.");
            //Console.Write("Which door?  (1/2/3): ");
            //int door = Int32.Parse(Console.ReadLine());
            //switch (door)
            //{
            //    case 1:
            //        Console.WriteLine("Red door - immenent death.  You are consumed by flames.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Blue door - oooooh, it's a snake!  But it is asleep.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Purple door - deadly daisies cause you to sneeze to death.");
            //        break;

            //}

            // p. 151 Conditional / ternary Operator: the ? operator
            //shipping status
            string shippingStatus = "2-day";
            decimal charge = 0M;

            charge = shippingStatus == "2-day" ? 5 : 2;


            //if status = 2-day, charge = $5.  Otherwise, charge =$2
            //if (shippingStatus == "2-day")
            //    charge = 5;
            //else
            //    charge = 2;
            Console.WriteLine($"charge = {charge}");



            // p. 155 While vs Do-While Loops
            //done this already, but don't use do-while

            // p. 157 For Loops
            //loops that run a certain number of times
            //count to ten:
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"i is {i}");
            }

            Console.WriteLine("2 to 20 by 2's");
            for (int i = 2; i <= 20; i+=2) 
            {
                Console.WriteLine($"i is {i}");
            }


            //// p. 159 Continue/Break in While / For Loops

            //while (true)
            //{
            //    Console.WriteLine("in an infinite loop!");
            //    Console.Write("Are you bored yet? (y/n): ");
            //    string answer = Console.ReadLine().ToLower();
            //    if (answer == "y")
            //    {
            //        break;
            //    }
            //}

            //while break and continue - prompt for even number, then times by ten, break when odd is entered
            //only accept max of 10 entered
            while (true)
            {
                int number = 0;

                Console.Write("Enter an even number: ");
                number = Int32.Parse(Console.ReadLine());
                if (number > 10)
                {
                    Console.WriteLine("Number greater than 10, try again.");
                    continue;
                }
                if (number % 2 == 0)
                {
                    Console.WriteLine("Even number entered");
                }
                else
                {
                    Console.WriteLine("odd number entered. boo.");
                    break;
                }
                int result = number * 10;
                Console.WriteLine($"Result is {result}");
            }

                // p. 161 Integrated Debugger

                Console.WriteLine("bye");
        }
    }
}
