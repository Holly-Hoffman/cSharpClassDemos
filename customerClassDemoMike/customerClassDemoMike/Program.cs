namespace customerClassDemoMike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Customer me = new Customer();
            me.Address = "123 xyz";
            me.City = "Oz";
            me.Name = "Holly";
            me.Id = 1;

            Console.WriteLine(me.ToString());
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string CustomerDesc()
        { return Name + " " + Address + " " + City; }

        public override string ToString()
        {
            return Name + " " + Address + " " + City;
        }
    }
}
