using bmdbIO.accesses;
using bmdbIO.models;

namespace bmdbIO
{
    internal class Program
    {
        private static MovieDB MovieDB = new MovieDB();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the movie database console app!\n");

            DisplayMenu();
            string command = "";
            while (command != "exit")
            {
                Console.Write("Command: ");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "list":
                        ListMovies();
                        break;
                    case "get":
                        GetMovies();
                        break;
                    case "add":
                        AddMovie();
                        break;
                    case "del":
                        DeleteMovie();
                        break;
                    case "upd":
                        UpdateMovie();
                        break;
                    case "menu":
                        DisplayMenu();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }

        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("list - list movies");
            Console.WriteLine("add  - add a movie");
            Console.WriteLine("get  - get a movie by ID");
            Console.WriteLine("del  - delete a movie");
            Console.WriteLine("upd  - update a field of a movie");
            Console.WriteLine("menu - display menu");
            Console.WriteLine("exit - exit app");
        }

        static void ListMovies()
        {
            Console.WriteLine("\nMovie List:");
            foreach (Movie movie in MovieDB.GetMovies())
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();
        }

        static void GetMovies()
        {
            Console.WriteLine("\nGet Movie By ID:");
            int viewID = Int32.Parse(PromptInput("ID: "));
            Movie mv = null;
            foreach (Movie movie in MovieDB.GetMovies())
            {
                if (movie.Id == viewID)
                {
                    mv = movie;
                }
            }

            if (mv != null)
            {
                Console.WriteLine(mv);
                Console.WriteLine();
            }
            else { Console.WriteLine("No such movie exists in this file.\n"); }
        }

        static void AddMovie()
        {

            Console.WriteLine("\nAdd a New Movie:");

            int newId = Int32.Parse(PromptInput("ID: "));
            string newTitle = PromptInput("Title: ");
            int newYear = Int32.Parse(PromptInput("Release Year: "));
            string newRating = PromptInput("Rating: ");
            string newdirector = PromptInput("Director: ");

            Movie userMovie = new Movie(newId, newTitle, newYear, newRating, newdirector);

            MovieDB.GetMovies().Add(userMovie);
            MovieDB.SaveMovies();
            Console.WriteLine($"{newTitle} has been added to the movie list!\n");
        }

        static void DeleteMovie()
        {
            Console.WriteLine("\nDelete a Movie By ID:");

            int viewMovie = Int32.Parse(PromptInput("ID: "));
            Movie mv = null;
            foreach (Movie movie in MovieDB.GetMovies())
            {
                if (movie.Id == viewMovie)
                {
                    mv = movie;
                }
            }

            if (mv != null)
            {
                MovieDB.GetMovies().Remove(mv);
                MovieDB.SaveMovies();
                Console.WriteLine($"Movie {mv.Title} has been removed from the list.\n");
            }
            else { Console.WriteLine("No such movie exists on the list.\n"); }
        }

        static void UpdateMovie()
        {
            Console.WriteLine("\nUpdate a Movie By ID:");

            int viewMovie = Int32.Parse(PromptInput("ID: "));
            Movie mv = null;
            foreach (Movie movie in MovieDB.GetMovies())
            {
                if (movie.Id == viewMovie)
                {
                    mv = movie;
                }
            }

            if (mv != null)
            {
                Console.Write("Field to be updated? (title, year, rating, director): ");
                string updatedField = Console.ReadLine().ToLower();
                switch (updatedField)
                {
                    case "title":
                        string newTitle = PromptInput("New title: ");
                        mv.Title = newTitle;
                        break;
                    case "year":
                        int newYear = Int32.Parse(PromptInput("New release year: "));
                        mv.Year = newYear;
                        break;
                    case "rating":
                        string newRating = PromptInput("New rating: ");
                        mv.Rating = newRating;
                        break;
                    case "director":
                        string newDirector = PromptInput("New director: ");
                        mv.Director = newDirector;
                        break;
                }

                MovieDB.SaveMovies();
                Console.WriteLine($"Movie ID {mv.Id} has been updated.\n");
            }
            else { Console.WriteLine("No such movie exists on the list.\n"); }
        }

        static string PromptInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

    }
}
