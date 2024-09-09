namespace ch12demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Classes Demo App!");
            //console is a class!  Teal = classes.
            //writeline = method, not instance.
            //each table will be its own class

            //define a class within Visual studio!
            //381 now.  right click on your project > add > class or project > add > class
            //"internal" = class modifier.  If it should be accessed by other classes, change to public.
            //This is totally not the case in java tho
            //since "main" is going to handle presentation w/console, we need to make classes public so main can use it.
            //"using" may be called other things in other languages.  Can be deleted if we won't use them.  idk when we would or wouldn't.
            //get and set = getter and setter in java
            //get and set are shorthand for methods to declare the "getter" and "setter"
            //allows us to set properties specfic to each thing (ex. p1.code) and to get that property (such as in a writeline$)
            //need to define them and will use them later.  Who knows when.


            //use the class
            int number = 5;
            //this is not using a class.  This is a tangent.

            //now we are using a class.  the code/description/price are PROPERTIES of the class.
            //without constructors:
            Product p1 = new Product();
            p1.Code = "c#";
            p1.Description = "Murach's C# Programming";
            p1.Price = 57.50M;

            //This is how to do it wrong:
            //Console.WriteLine($"p1: {p1}");

            //This actually works when we have no constructors:
            Console.WriteLine($"p1: {p1.Code}, {p1.Description}, {p1.Price}");

            // p. 385 Method that accepts parameters

            // p. 387 Constructors
            //called when you declare a new instance of a thing
            //This would fail if you had no constructors

            Product p2 = new Product("java", "Murach's java programming", 59.50M);

            Product p3 = new Product("andr", "murach's android programming", 62.50M);
            Console.WriteLine(p3.ToString());

            Console.WriteLine("pass p1 directly to WriteLine: " + p1.ToString());

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            Console.WriteLine("List of products:");
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("find product by code\n");
            Console.Write("Enter a code: ");
            string code = Console.ReadLine();

            Product foundProduct = null;
            foreach (Product p in products)
            {
                if (p.Code == code)
                {
                    foundProduct = p;
                    break;
                }
            }

            if (foundProduct != null)
            {
                Console.WriteLine($"Found product: {foundProduct}");
            }
            else
            {
                Console.WriteLine($"Invalid entry. No product found for code {code}");
            }

            //onsole.WriteLine($"object count p1: {Product.ObjectCount.}");

            // p. 389 Static members


            // p. 391 Form - skip

            // p. 403 required parameters - skip

            // p. 405 - skip

            // p. 408 - discuss but skip




            Console.WriteLine("Bye");
        }
    }
}
