namespace StringSplosionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which word should we blow up? ");
            string sploded = Console.ReadLine();
            Console.WriteLine($"Exploded: {StringSplosion(sploded)}");


        }
        public static string StringSplosion(string str)
        {
            string NewString = "";
            //test case "Code" needs to be "CCoCodCode"
            //index for loop
            for (int i = 0; i <= str.Length; i++)
            {
                NewString += str.Substring(0, i);
            }

            //need to get the substring (0,i)
            //newString += str.substring(0,i)
            return NewString;
        }
    }

}
