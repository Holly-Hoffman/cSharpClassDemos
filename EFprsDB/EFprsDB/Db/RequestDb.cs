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
    internal class RequestDb
    {
        private PRSDBContext dbContext = new PRSDBContext();

        //crud methods
        public List<Request> GetRequests()
        {
            return dbContext.Requests.ToList();
        }

        public Request FindRequest(int id)
        {
            return dbContext.Requests.Where(a => a.Id == id).FirstOrDefault();
        }

        public void AddRequest(Request request)
        {
            dbContext.Requests.Add(request);
            dbContext.SaveChanges();
        }

        public void UpdateRequest(Request request)
        {
            dbContext.SaveChanges();
        }

        public void RemoveRequest(Request request)
        {
            dbContext.Requests.Remove(request);
            dbContext.SaveChanges();
        }

    }
}
