using ProductManagerFileIO.models;

namespace ProductManagerFileIO.DataAccess
{
    /*Product DB is a class that will
     * manage the connecction and IO
     * with our Products.txt file
     */
    public class ProductDB
    {
        string path = @"D:\files\Products.txt";
        List<Product> products = new();

        public List<Product> GetProducts() { return products; }

        public ProductDB()
        {
            //load, or initialize, our products from the .txt to the list
            LoadProducts();
        }

        public void SaveProducts()
        {
            using StreamWriter productsWriter = new(new FileStream(path, FileMode.Create, FileAccess.Write));
            foreach (Product p in products)
            {
                productsWriter.WriteLine($"{p.Code}|{p.Description}|{p.Price}");
            }

        }

        private void LoadProducts()
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

    }
}
