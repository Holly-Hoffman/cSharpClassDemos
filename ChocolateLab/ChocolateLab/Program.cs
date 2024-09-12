namespace ChocolateLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the start");

            int goal = 7;
            Console.WriteLine($"goal: {goal}\nbig bars used: {goal/5}\nsmall bars used: {goal%5}");
            Console.WriteLine(MakeChocolate(goal%5, goal/5, goal));


            Console.WriteLine("This is the end");
        }

        public static int MakeChocolate(int small, int big, int goal)
        {

            small = goal % 5;
            big = goal / 5;
            int number = 0;

            if (small == 0)
            {
                number = -1;
            }
            else
            {
                number = small;

            }

            return number;
        }
    }
}
