namespace ReplaceCharsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vowels have been abolished!");
            Console.Write("Enter a sentence: ");
            string s = Console.ReadLine();
            string newString = ReplaceVowelsWithUnderscores(s);
            Console.WriteLine($"{newString}");
        }
        public static string ReplaceVowelsWithUnderscores(string s)
        {

            string newString = s.Replace('a', '_').Replace('e', '_').Replace('i', '_').Replace('o', '_').Replace('u', '_').Replace('y', '_')
                .Replace('A', '_').Replace('E', '_').Replace('I', '_').Replace('O', '_').Replace('U', '_').Replace('Y', '_');

                return newString;

        }
    }
}

