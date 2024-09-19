namespace NullableTypesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the nullable types demo");

            //string defined as empty, but not null.
            string s = "";

            //string that is null
            string n = null;

            Console.WriteLine($"S = {s}, N = {n}.");

            Console.WriteLine("Bye bye bye");
        }
    }
}
