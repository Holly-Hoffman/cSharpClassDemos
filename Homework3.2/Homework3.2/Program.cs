namespace Homework3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator!");

            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine();
                Console.Write("Enter Miles:          ");
                double dMiles = double.Parse(Console.ReadLine());
                Console.Write("Enter miles per hour: ");
                double dMPH = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Estimated travel time");
                Console.WriteLine("-----------------");
                //int miles = Convert.ToInt32(dMiles);
                //int MPH = Convert.ToInt32(dMPH);

                double dHours = dMiles / dMPH;
                //Console.WriteLine(dHours);
                int hours = (int)dHours;
                double minutes = (int)(((dMiles / dMPH) - hours) * 60);


                //int hours = miles / MPH;
                //int minutes = miles % MPH;
                

                Console.WriteLine($"Hours:   {hours}");
                Console.WriteLine($"Minutes: {minutes}");
                Console.WriteLine();
                Console.Write("Continue?  (y/n): ");
                choice = Console.ReadLine().ToLower();
        
            }
        }
    }
}
