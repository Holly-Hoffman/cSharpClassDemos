using EFprsDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EFprsDB.Db
{
    internal class ProductDb
    {
        private PRSDBContext dbContext = new PRSDBContext();

        //crud methods
        public List<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }

        public Product FindProduct(int id)
        {
            return dbContext.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        public void AddProduct(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            dbContext.SaveChanges();
        }

        public void RemoveProduct(Product product)
        {
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
        }

    }
}
