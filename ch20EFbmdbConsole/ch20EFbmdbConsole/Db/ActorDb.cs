using ch20EFbmdbConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch20EFbmdbConsole.Db
{
    internal class ActorDb
    {
        private BMDBContext dbContext = new BMDBContext();

        //crud methods
        public List<Actor> GetActors()
        {
            return dbContext.Actors.ToList();
        }

        public Actor FindActor(int id)
        {
            return dbContext.Actors.Where(a => a.Id == id).FirstOrDefault();
        }

        public void AddActor(Actor actor)
        {
            dbContext.Actors.Add(actor);
            dbContext.SaveChanges();
        }

        public void UpdateActor(Actor actor)
        {
            dbContext.SaveChanges();
        }

        public void RemoveActor(Actor actor)
        {
            dbContext.Actors.Remove(actor);
            dbContext.SaveChanges();
        }
    }
}
