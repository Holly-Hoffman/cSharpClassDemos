using ProductDemo.Models;

namespace ProductDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Manager!");

            Book p1 = new Book();
            p1.Id = 1;
            p1.Code = "C#";
            p1.Description = "Murach's C#";
            p1.Price = 59.5M;
            p1.Author = "Joel Murach";
            Console.WriteLine(p1.Id);
            Console.WriteLine(p1.Code);
            Console.WriteLine(p1.Description);
            Console.WriteLine(p1.Price);
            Console.WriteLine(p1.Author);

            Book p2 = new Book(2, "JAVA", "Murach's Java Programming", 57.5M, "Joel Murich");
            Book b1 = new Book(3, "mysql", "Murach's MySQL", 54.29M, "Joel Murach");
            Software s1 = new Software(4, "VSC", "VS Code", 0.0M, "v1.93");

            Console.WriteLine(p2);
            Console.WriteLine(b1);
            Console.WriteLine(s1);

            Console.WriteLine("\nList of products:");
            List<Product> productList = new List<Product> {p1, p2, b1, s1 };
            
            PrintProducts(productList);

            Console.WriteLine("Thank you for using the Product Manager!");
        }
        private static void PrintProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                product.PrintToWeb();
            }
        }
    }
}
