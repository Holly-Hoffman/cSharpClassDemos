using ProductManagerFileIO.DataAccess;
using ProductManagerFileIO.models;


namespace ProductManagerFileIO
{
    internal class Program
    {
        private static ProductDB ProductDB = new ProductDB();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Manager App!");


            DisplayMenu();

            string command = "";
            while (command != "exit")
            {
                Console.Write("Command: ");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "list":
                        ListProducts();
                        break;
                    case "get":
                        GetProduct();
                        break;
                    case "add":
                        AddProduct();
                        break;
                    case "del":
                        DeleteProduct();
                        break;
                    case "menu":
                        DisplayMenu();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }

            Console.WriteLine("Bye");
        }
        static void ListProducts()
        {

            Console.WriteLine("\nProduct List:");
            foreach (Product p in ProductDB.GetProducts())
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

        }

        static void GetProduct()
        {
            Console.WriteLine("\nGet Product By Code:");
            string viewCode = PromptInput("Code: ").ToUpper();
            Product pdt = null;
            foreach (Product product in ProductDB.GetProducts())
            {
                if (product.Code == viewCode)
                {
                    pdt = product;
                }
            }
            if (pdt != null)
            {
                Console.WriteLine(pdt);
                Console.WriteLine();
            }
            else { Console.WriteLine("No such product exists.\n"); }

            // prompt user for code
            // find product in list, by code
            // display product
        }

        static void AddProduct()
        {

            Console.WriteLine("\nAdd a New Product:");

            string newCode = PromptInput("Code: ").ToUpper();
            string newDesc = PromptInput("Description: ");
            decimal newPrice = Decimal.Parse(PromptInput("Price: "));

            Product userProduct = new Product(newCode, newDesc, newPrice);

            ProductDB.GetProducts().Add(userProduct);
            ProductDB.SaveProducts();
            Console.WriteLine($"{newDesc} has been added to Products!\n");

            // prompt user for code, desc, price
            // create new instance of product
            // add product to list
            // SAVE PRODUCT FILE
        }

        static void DeleteProduct()
        {
            Console.WriteLine("\nDelete a Product By Code:");

            string viewCode = PromptInput("Code: ").ToUpper();
            Product pdt = null;
            foreach (Product product in ProductDB.GetProducts())
            {
                if (product.Code == viewCode)
                {
                    pdt = product;
                }
            }

            if (pdt != null)
            {
                ProductDB.GetProducts().Remove(pdt);
                ProductDB.SaveProducts();
                Console.WriteLine($"Product {viewCode} has been removed from the list.\n");
            }
            else { Console.WriteLine("No such product exists.\n"); }
        }

        // prompt user for product code
        // find product by code
        // if product does not exist, display message
        // if product exists, delete product and SAVE PRODUCT FILE



        static void DisplayMenu()
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("list - list products");
            Console.WriteLine("add  - add a product");
            Console.WriteLine("get  - get a product by code");
            Console.WriteLine("del  - delete a product");
            Console.WriteLine("menu - display menu");
            Console.WriteLine("exit - exit app");
        }

        
        static string PromptInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}