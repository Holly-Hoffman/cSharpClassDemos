using FilesDemos.models;

namespace FilesDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Processing 101!");

            //////establishing the file path
            //////pg 559
            //string path = @"D:\files\Names.txt";
            ////commented this out once I made the folder vvvv
            ////FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            ////fs.Close();

            ////pg 563 write to a file
            ////making a new streamfile - first "new" is really new StreamWriter
            //StreamWriter textOut = new(new FileStream(path, FileMode.Create, FileAccess.Write));
            //textOut.WriteLine("Brandon Moore");
            //textOut.WriteLine("Sarika Srivastava");
            //textOut.WriteLine("Graydon Kappes");
            //textOut.Close();

            ////pg 565 - read data from a text file
            //StreamReader textIn = new(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            ////textIn.ReadLine(); //will read only one line at a time.  If at the end, will return null.
            //string line = textIn.ReadLine();
            //string line = textIn.ReadLine();
            //Console.WriteLine("Names:");
            //while (line != null)
            //{
            //    Console.WriteLine(line); //writing the line
            //    line = textIn.ReadLine(); //calling the next line
            //}



            //=================================================


            ////Read and write multiple fields per line.

            ////create instances of products
            //Product p1 = new Product("JAVA", "Murach's Java", 57.50M);
            //Product p2 = new Product("C#", "Murach's C#", 58.50M);
            //Product p3 = new Product("ANDRIOD", "Murach's Andriod", 59.50M);

            ////anything in <> is "generic" - it will accept any type of data
            //List<Product> products = new List<Product>();
            //products.Add(p1);
            //products.Add(p2);
            //products.Add(p3);

            //Console.WriteLine("Products: ");
            //foreach (Product p in products)
            //{
            //    Console.WriteLine(p);
            //}
            //Console.WriteLine("Write Products to file");


            //string path = @"D:\files\Products.txt";

            ////"using" lets c# auto-close the file for us.
            //using StreamWriter textOut = new(new FileStream(path, FileMode.Create, FileAccess.Write));

            ////we are going to parse these into proper fields and add delimiters (which is like a , or |) to each line
            //foreach (Product p in products)
            //{
            //    textOut.Write(p.Code + "|");
            //    textOut.Write(p.Description + "|");
            //    textOut.WriteLine(p.Price);
            //    //whatever code | whatever desc | price
            //    //second code | second desc | price
            //}

            //=============================================

            //Read Products.txt, change (parse) rows into products, add it to a list, then print from that list to the console.

            string path = @"D:\files\Products.txt";
            List<Product> products = new List<Product>();
            using StreamReader textIn = new(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] fields = row.Split('|');
                if (fields.Length == 3)

                {
                    string code = fields[0];
                    string description = fields[1];
                    decimal price = Decimal.Parse(fields[2]);
                    Product p = new Product(code, description, price);
                    products.Add(p);
                }

            }

            Console.WriteLine("Products from file:");
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }


            Console.WriteLine("this is the end.");
        }
    }
}
