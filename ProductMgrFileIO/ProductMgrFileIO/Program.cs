using ProductMgrFileIO.models;

namespace ProductMgrFileIO
{
    internal class Program
    {
        static List<Product> products = new();
        // Declare file path for use later
        //string path = @"D:\files\Products.txt";
        static string path = @"D:\files\Products.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Manager App!");
            //load products from file into products list
            LoadProducts();

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
            foreach (Product p in products)
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
            foreach (Product product in products)
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

            products.Add(userProduct);
            SaveProducts();
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
            foreach (Product product in products)
            {
                if (product.Code == viewCode)
                {
                    pdt = product;
                }
            }

            if (pdt != null)
            {
                products.Remove(pdt);
                SaveProducts();
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

        // NEW METHODS:
        // SAVE PRODUCT FILE
        static void SaveProducts()
        {
            using StreamWriter productsWriter = new(new FileStream(path, FileMode.Create, FileAccess.Write));
            foreach (Product p in products)
            {
                productsWriter.WriteLine($"{p.Code}|{p.Description}|{p.Price}");
            }

        }

        // LOAD PRODUCTS FROM FILE

        static void LoadProducts()
        {
            //create  a streamreader to access file
            using StreamReader productsReader = new(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            //read the lines from the file
            while (productsReader.Peek() != -1)
            {
                string row = productsReader.ReadLine() ?? "";  //we don't really need the ??"" if we have the != -1 up top.  It is double-validation.
                string[] fields = row.Split('|');
                //parse the fields from each line into a product
                if (fields.Length == 3)

                {
                    string code = fields[0];
                    string description = fields[1];
                    decimal price = Decimal.Parse(fields[2]);
                    Product p = new Product(code, description, price);
                    //add each product to the products list
                    products.Add(p);
                }

            }

        }
        static string PromptInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}