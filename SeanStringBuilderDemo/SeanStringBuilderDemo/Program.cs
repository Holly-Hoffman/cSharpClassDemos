using System.Text;

namespace SeanStringBuilderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string str1 = "abc";
            Console.WriteLine(str1);
            str1 += "def";
            Console.WriteLine(str1);

            Console.WriteLine("Using stringbuilder:");
            StringBuilder sb1 = new StringBuilder();
            sb1.Append(str1);
            Console.WriteLine(sb1);
            sb1.Remove(2,2);
            Console.WriteLine(sb1);
        }
    }
}
