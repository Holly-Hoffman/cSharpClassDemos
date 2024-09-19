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
    internal class UserDb
    {
        private PRSDBContext dbContext = new PRSDBContext();

        //crud methods
        public List<User> GetUsers()
        {
            return dbContext.Users.ToList();
        }

        public User FindUser(int id)
        {
            return dbContext.Users.Where(u => u.Id == id).FirstOrDefault();
        }

        public void AddUser(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            dbContext.SaveChanges();
        }

        public void RemoveUser(User user)
        {
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }

    }
}
