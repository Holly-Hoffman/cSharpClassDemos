using System.Runtime.Remoting;

namespace PeopleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Employee e1 = new();
            Customer c1 = new();

            e1.City = "Cincinnati";
            e1.Street = "123 Main St";
            e1.State = "OH";
            e1.Zip = "12345";
            e1.FirstName = "Mike";
            e1.LastName = "Smith";

            e1.City = "Cincinnati";
            e1.Street = "321 Main St";
            e1.State = "OH";
            e1.Zip = "12345";
            e1.FirstName = "Jerry";
            e1.LastName = "Smith";

            PrintLabel(e1);

            decimal dec;
            int i;
            i = 5;

            dec = i; // implicit cast, aka safe

            Customer c2;
            Person d = new Person();
            d = (Person)e1;

            Employee e3 = (Employee)d;
            

            Console.WriteLine("the end!");
        } u

        static void PrintLabel(Person P)
        {
            Console.WriteLine($"{P.FirstName} {P.LastName} \n{P.Street}, \n {P.City}, {P.State} {P.Zip}");
        }
    }
}
