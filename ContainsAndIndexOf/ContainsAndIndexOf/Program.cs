namespace ContainsAndIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //word guess game - does a letter occur in the word
            string theWord = "superstar";
            Console.WriteLine(theWord);

            while (true)
            {
                Console.Write("guess a letter: ");
                string letter = Console.ReadLine();

                if (letter == "exit") { break; }

                //does the letter exist in the word?
                //index of....
                Console.WriteLine($"theWord.IndexOf(letter): {theWord.IndexOf(letter)}");
                //contains
                Console.WriteLine($"theWord.Contains(letter): {theWord.Contains(letter)}");
            }
        }
    }
}
