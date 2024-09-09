namespace ch12demos
{
    public class Product
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //any time we create an instance of this product, we will increase this number
        //usually, we will not need to use this.  It is only for demo purposes.
        public static int ObjectCount { get; set; }

        public Product()
        {
            ObjectCount++;
        }
    
        //this is setting constructors
        public Product(string code, string description, decimal price)
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;
            ObjectCount++;
        }

        //without constructors
       // public Product() { }



        //Adding a method for our new class.
        //it has no "static" because
        //override ToString() [used to be GetDetails()]
        public override string ToString()
        {
            return $"Product: code - '{this.Code}', description - '{this.Description}', price '{this.Price}'" + 
            $"ObjectCount - '{Product.ObjectCount}'";
        }
    }
}
