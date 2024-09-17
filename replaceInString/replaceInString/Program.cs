namespace replaceInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is how we replace chars in a string.");

            //making *s to +s

            string asterisk = "**********";

            Console.WriteLine($"star word: {asterisk}");

                char[] stringArray = asterisk.ToCharArray();
            for (int i = 0; i < asterisk.Length; i++)
            {
                stringArray[i] = '+';
            }

            string newString = new string(stringArray);

            Console.WriteLine(newString);

        }
    }
}
