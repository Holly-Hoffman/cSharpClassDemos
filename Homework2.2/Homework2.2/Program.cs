using System.ComponentModel.Design;

namespace Homework2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter");
           
            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter numerical grade: ");
                string score = Console.ReadLine();
                int grade = int.Parse(score);
                if (grade > 87) { Console.WriteLine("Letter grade: A"); }
                else if (grade >= 80) { Console.WriteLine("Letter grade: B"); }
                else if (grade >= 67) { Console.WriteLine("Letter grade: C"); }
                else if (grade >= 60) { Console.WriteLine("Letter grade: D"); }
                else { Console.WriteLine("Letter grade: F"); }

                Console.WriteLine();
                Console.Write("Continue?  (y/n): ");
                string response = Console.ReadLine().ToLower();
                if (response != "y")
                { break; }
            

            
            
            }
        }
    }
}
