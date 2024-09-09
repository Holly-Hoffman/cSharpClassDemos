using System.Data.Common;

namespace MovieLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This is my array of movie tuples. Give 'em a watch!");

            //var Movies = new (int id, string title, int year, string rating, string director)[4,5];
            //Movies[0, 0] = 1, "The Shawshank Redeption", 1994, "R", "Frank Daranbont";
            //Console.Write($"{Movies}");

            Console.WriteLine("Welcome to the Movie Array App!");

            var movies = new[] {
                (title: "The Shawshank Redeption", year: 1994, rating: "R", director: "Frank Darabont"),
                (title: "Cloud Atlas", year: 2012, rating: "R", director: "Tom Tykwer")

                };
            foreach (var movie in movies)
            {
                Console.WriteLine($"Title: {movie.title}");
                Console.WriteLine($"Year: {movie.year}");
                Console.WriteLine($"Rating: {movie.rating}");
                Console.WriteLine($"Director: {movie.director}");
                Console.WriteLine();
            }



        }
    }
}
