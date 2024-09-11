
using System.Diagnostics;

namespace ProductDemo.Models
{
    internal abstract class Product : IWebPrintable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //this is a constructor!
        public Product(int id, string code, string description, decimal price)
        {
            Id = id;
            Code = code;
            Description = description;
            Price = price;
        }

        public Product() {
            Id = 0;
            Code = "";
            Description = "";
            Price = 0M;
        }

        public override string ToString()
        {
            return $"\nProduct: ID: {Id}\nCode: {Code}\nDescription: {Description}\nPrice: {Price}";
        }

        public virtual void PrintToWeb()
        {
            Console.WriteLine($"{Description} ({Code}) - ${Price}");
        }
    }
}
