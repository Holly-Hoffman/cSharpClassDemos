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
    internal class VendorDb
    {
        private PRSDBContext dbContext = new PRSDBContext();

        //crud methods
        public List<Vendor> GetVendors()
        {
            return dbContext.Vendors.ToList();
        }

        public Vendor FindVendor(int id)
        {
            return dbContext.Vendors.Where(a => a.Id == id).FirstOrDefault();
        }

        public void AddVendor(Vendor vendor)
        {
            dbContext.Vendors.Add(vendor);
            dbContext.SaveChanges();
        }

        public void UpdateVendor(Vendor vendor)
        {
            dbContext.SaveChanges();
        }

        public void RemoveVendor(Vendor vendor)
        {
            dbContext.Vendors.Remove(vendor);
            dbContext.SaveChanges();
        }

    }
}
