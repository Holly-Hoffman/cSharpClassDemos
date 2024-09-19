using ch20EFbmdbConsole.Models;

namespace ch20EFbmdbConsole.Db
{
    internal class MovieDb
    {
        private BMDBContext dbContext = new BMDBContext();

        //crud methods
        public List<Movie> GetMovies()
        {
            return dbContext.Movies.ToList();
        }

        public Movie FindMovie(int id)
        {
            return dbContext.Movies.Where(m => m.Id == id).FirstOrDefault();
        }

        public void AddMovie(Movie movie)
        {
            dbContext.Movies.Add(movie);
            dbContext.SaveChanges();
        }

        public void UpdateMovie(Movie movie)
        {
            dbContext.SaveChanges();
        }

        public void RemoveMovie(Movie movie)
        {
            dbContext.Movies.Remove(movie);
            dbContext.SaveChanges();
        }
    }

}
