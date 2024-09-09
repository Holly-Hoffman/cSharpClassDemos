namespace DateLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the date of the invoice: ");
            DateTime.TryParse(Console.ReadLine(), out DateTime invoiceDate);
            DateTime dueDate = invoiceDate.AddDays(30);
            Console.WriteLine($"Your due date is {dueDate}.");

            string myString = "Hello world!";
            Console.WriteLine(myString);

            string newString = myString.ToUpper();
            Console.WriteLine(newString);

            string theMsg = "Hello yournamegoeshere welcome to citygoeshere";
            //theMsg.Replace("yournamegoeshere", "mike");

            decimal amount = 1234.56M;  //M is used because deciMal (all other letters were used already)
            string user = "Mike";
            string city = "Cincinnati";

            string theNewMsg = String.Format("Hello {0} welcome to {1}.  Please spend {2} whilke you are here.", user, city);


            string theFinalMsg = $"Hello {user} welcome to {city}.  Please spend {amount} while you are here.";
            Console.WriteLine(theFinalMsg);
        }
    }
}
