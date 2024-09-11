namespace ProductDemo.Models
{
    internal sealed class Software : Product, IWebPrintable
    {

        public string Version { get; set; }
        public Software(int id, string code, string description, decimal price, string version) :
            base(id, code, description, price)
        { Version = version; }

        public override string ToString()
        {
            return base.ToString() + $"\nVersion: {Version}";
        }

        public override void PrintToWeb()
        {
            base.PrintToWeb();
            Console.WriteLine($" {Version}");
        }
    }
}
