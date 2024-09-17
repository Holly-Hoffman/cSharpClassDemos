namespace StringBitsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How can we truncate your words?\nLet's just chop out every other letter!");
            Console.Write("What word should we shorten? ");
            string str = Console.ReadLine();
            string strShort = StringBits(str);
            Console.WriteLine(strShort);
        }

        public static string StringBits(string str)
        {
            //char replacement = '*';
            char[] chars = str.ToCharArray();
            for (int i = 1; i < chars.Length; i += 2)
            {
                if (char.IsLetter(chars[i]))
                {
                    chars[i] = Remove(i, 1);
                }
            }


            return new string(chars);
        }
    }
}
