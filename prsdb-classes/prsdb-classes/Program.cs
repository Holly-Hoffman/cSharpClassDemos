using prsdb_classes.Models;

namespace prsdb_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSectionHeader("Welcome to the Purchase Request System Console App!");
            PrintSectionHeader("Create some users");
            Users u1 = new Users(1, "Boomerang Guy", "p0nytail!", "Sokka", "Water Tribe", "555-5555", "WangFire@watertribe.net", true, true);

            //fix the date only
            PrintSectionHeader("Create some requests");
            Request req1 = new Request(1, u1, "1", "Need travel companion", "Jealous of Aang and Momo", 2024.10.10, "Airship", "NEW", 0.0M, DateTime.Now, null);

        }
        private static void PrintSectionHeader(string sectionHeader)
        {
            Console.WriteLine(GetSeparator('=', sectionHeader.Length));
            Console.WriteLine(sectionHeader);
            Console.WriteLine(GetSeparator('=', sectionHeader.Length));
        }

        private static string GetSeparator(char separator, int length)
        {
            string separatorString = "=";
            separatorString = separatorString.PadRight(length, '=');
            return separatorString;
        }
    }
}
