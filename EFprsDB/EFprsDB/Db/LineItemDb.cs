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
    internal class LineItemDb
    {
        private PRSDBContext dbContext = new PRSDBContext();

        //crud methods
        public List<LineItem> GetLineItems()
        {
            return dbContext.LineItems.ToList();
        }

        public LineItem FindLineItem(int id)
        {
            return dbContext.LineItems.Where(l => l.Id == id).FirstOrDefault();
        }

        public void AddLineItem(LineItem lineItem)
        {
            dbContext.LineItems.Add(lineItem);
            dbContext.SaveChanges();
        }

        public void UpdateLineItem(LineItem lineItem)
        {
            dbContext.SaveChanges();
        }

        public void RemoveLineItem(LineItem lineItem)
        {
            dbContext.LineItems.Remove(lineItem);
            dbContext.SaveChanges();
        }

    }
}
