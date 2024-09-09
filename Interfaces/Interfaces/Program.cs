namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Customer c1 = new();
            c1.Id = 1;
            c1.LName = "Pyrak";
            c1.FName = "Cassie";
            c1.Street = "Our house";
            c1.City = "In the middle of our street";
            c1.State = "In the middle of our town";
            c1.ZIP = "55555";

            Customer c2 = new();
            c2.Id = 1;
            c2.LName = "Pyrak";
            c2.FName = "Cassie";
            c2.Street = "Our house";
            c2.City = "In the middle of our street";
            c2.State = "In the middle of our town";
            c2.ZIP = "55555";

            //if (c1.CompareTo(c2)) {
            //}

            Vendor v1 = new();
            v1.VenId = 1;
            v1.CoName = "Pyrak, LLC";
            v1.Street = "Our company";
            v1.City = "In the middle of our street";
            v1.State = "In the middle of our town";
            v1.ZIP = "55555";



        }
        static void PrintLabel(ILabel l)
        {
            Console.WriteLine($"{l.Street}, {l.City}, {l.Street} {l.ZIP}");
        }
    }

    //contract
    interface ILabel
    {
        string DisplayName { get; }
        string Street { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZIP { get; set; }
    }

    interface IManageable
    {
        string ManagerName { get; set; }
        int ReviewWks { get; set; }
        bool IsRevDone();
        void LastRevDate(DateTime review);
    }

    //this is the annoying way to do it
    class Customer : ILabel, IManageable
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public string ManagerName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ReviewWks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string DisplayName { get { return FName + " " + LName; } }

        public bool IsRevDone ()
        {  return true; }

        public void LastRevDate(DateTime review)
        {
            throw new NotImplementedException();
        }
    }

    //    public int CompareTo(object? obj)
    //    {
    //        Customer othercustomer = (Customer)obj;
    //        if (this.LName > othercustomer.LName) { return 1; }
    //        else if (this.LName < othercustomer.LName) { return -1; }
    //        else { return 0; }
    //        throw new NotImplementedException;
    //    }
    //}

    //use the lightbulb to auto-complete
    class Vendor : ILabel, IManageable
    {
        public int VenId { get; set; }
        public string CoName { get; set; }
        public string Street { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string City { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string State { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ZIP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ManagerName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ReviewWks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string DisplayName => throw new NotImplementedException();

        public bool IsRevDone()
        {
            throw new NotImplementedException();
        }

        public void LastRevDate(DateTime review)
        {
            throw new NotImplementedException();
        }
    }

    class Car : ILabel, IManageable, IComparable
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Street { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string City { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string State { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ZIP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ManagerName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ReviewWks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string DisplayName => throw new NotImplementedException();

        public int CompareTo(object? obj)
        {
            return VIN.CompareTo(((Car)obj).VIN);
        }

        public bool IsRevDone()
        {
            throw new NotImplementedException();
        }

        public void LastRevDate(DateTime review)
        {
            throw new NotImplementedException();
        }
    }
    class Person { }
}

