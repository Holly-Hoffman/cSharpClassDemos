using SalesDatabaseEFConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabaseEFConsole.Db
{
    internal class CustomerDb
    {
        private SALESDBContext dbContext = new SALESDBContext();

        //CRUD functions
        public List<Customer> GetCustomers() 
        {
            return dbContext.Customers.ToList();
        }

        public Customer FindCustomer(int id)
        {
            return dbContext.Customers.Where(c => c.Id == id).FirstOrDefault();
        }

        public void AddCustomer(Customer customer)
        {
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            dbContext.SaveChanges();
        }

        public void RemoveCustomer(Customer customer) 
        {
            dbContext.Customers.Remove(customer);
            dbContext.SaveChanges();
        }
    }
}
