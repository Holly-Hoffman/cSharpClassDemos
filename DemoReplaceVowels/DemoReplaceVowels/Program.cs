using System.Text.RegularExpressions;

namespace DemoReplaceVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string choice = "y";
            while (choice == "y")
            {
                Console.Write("Enter sentence: ");
                string sentence = Console.ReadLine();

                string newSentence = ReplaceVowelsWithUnderscoresRegex(sentence);
                Console.WriteLine($"Old sentence {sentence}.");
                Console.WriteLine($"New sentence: {newSentence}");
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();

            }
        }

        public static string ReplaceVowelsWithUnderscores(string s)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };

            foreach (char vowel in vowels)
            {
                s = s.Replace(vowel, '_');
            }
            return s;
        }

        private static String ReplaceVowelsWithUnderscoresRegex(String sentence)
        {
            sentence = Regex.Replace(sentence, "[aeiouyAEIOUY]", "_");
            return sentence;
        }
    }
}
