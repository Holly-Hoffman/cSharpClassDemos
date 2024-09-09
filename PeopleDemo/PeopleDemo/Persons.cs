using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleDemo
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

    }

    internal class Employee : Person
    {
        public string PayrollId { get; set; }
        public DateTime HireDate { get; set; }
    }
    internal class Customer : Person
    {
        public string CustomerId { get; set; }
        public decimal CreditLimit { get; set; }
    }
}
