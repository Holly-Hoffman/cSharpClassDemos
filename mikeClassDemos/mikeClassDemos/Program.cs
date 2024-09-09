namespace mikeClassDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Customer c = new Customer();
            Customer fred = new Customer();

            c.FirstName = "Mike";
            c.LastName = "Smith";
            c.CreditLimit = -100;
            fred.FirstName = "Sam";

            Console.WriteLine("bye");
        }
    }

    class Customer
    {
        //fields
        //public string FirstName;
        //public string LastName;
        //public decimal CreditLimit;

        //properties
        
        //self-implementing property; can implement getter and setter logic later
        public string MidInit {get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _creditLimit;

        public int CreditLimit
        {
            get { return _creditLimit; }
            set
            {
                if (value < 0)
                {
                    //Console.WriteLine("Bad!");
                    throw new ArgumentException("Bad credit limit.");
                }
                else
                {
                    _creditLimit = value;
                }
            }
        }


        //methods

        //events

    }
}
