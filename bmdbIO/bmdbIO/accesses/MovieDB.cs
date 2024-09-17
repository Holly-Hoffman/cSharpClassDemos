using bmdbIO.models;

namespace bmdbIO.accesses
{
    public class MovieDB
    {
        private const string Dir = @"D:\files\";
        private const string Path = Dir + "Movies.txt";
        private const string Sep = "|";

        List<Movie> movies = new();
        public List<Movie> GetMovies() { return movies; }

        public void SaveMovies()
        {
            using StreamWriter moviesWriter = new(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));
            foreach (Movie movie in movies)
            {
                moviesWriter.WriteLine($"{movie.Id}|{movie.Title}|{movie.Year}|{movie.Rating}|{movie.Director}");
            }

        }

        private void LoadMovies()
        {
            using StreamReader moviesReader = new(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));
            while (moviesReader.Peek() != -1)
            {
                string row = moviesReader.ReadLine();
                string[] fields = row.Split('|');

                if (fields.Length == 5)
                {
                    int id = Int32.Parse(fields[0]);
                    string title = fields[1];
                    int year = Int32.Parse(fields[2]);
                    string rating = fields[3];
                    string director = fields[4];

                    Movie movie = new Movie(id, title, year, rating, director);
                    movies.Add(movie);
                }
            }
        }

        public MovieDB()
        {
            LoadMovies();
        }

    }
}
