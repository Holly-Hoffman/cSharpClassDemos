namespace ch9demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DateTime myDate = DateTime.Now;
            Console.WriteLine(myDate);
            Console.WriteLine($"Your order date is {myDate}");
            Console.WriteLine($"Your payment is due {myDate.AddDays(30)}");


            DateTime myDate2 = DateTime.Parse("2003/01/02");
            Console.WriteLine(myDate2);

            DateTime myDate3 = new DateTime(2024, 9, 5);
            Console.WriteLine(myDate3);

            //DateTime myDate4 = DateTime.Parse("2024/02/30");
            //Console.WriteLine(myDate4);

            DateTime theUsersDate;

            bool success = DateTime.TryParse("2024/02/03", out theUsersDate);
            if (success)
            {
                Console.WriteLine($"The date is {theUsersDate}.");
            }
            else
            {
                Console.WriteLine("Please consult your rubber duck.");
            }

            DateTime myDate5 = DateTime.Now;
            Console.WriteLine(myDate5);

            DateTime myDate6 = DateTime.Today;
            Console.WriteLine($"Today is {myDate6}");

            Console.WriteLine(myDate6.ToShortDateString());
            Console.WriteLine(myDate6.ToLongDateString());
            Console.WriteLine(myDate6.ToString("MMM/dd-yyyy"));

            Console.WriteLine("The end.");
        }
    }
}
