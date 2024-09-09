using System.Runtime.InteropServices;

namespace bmdbManager
{
    internal class Program
    {
        static List<Movie> movies = new List<Movie>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Boot Camp Movie Database App!");

            //inputting the movies
            Movie TSR = new Movie(1, "The Shawshank Redemption", 1994, "R", "Frank Darabont");
            Movie CA = new Movie(2, "Cloud Atlas", 2012, "R", "Tom Tykwer, Lana Wachowski, Lilly Wachowski");
            Movie RO = new Movie(3, "Rogue One: A Star Wars Story", 2016, "PG-13", "Gareth Edwards");
            Movie LOTR = new Movie(4, "Lord of the Rings: The Fellowship of the Ring", 2001, "PG-13", "Peter Jackson");
            Movie HF = new Movie(5, "Hot Fuzz,", 2007, "R", "Edgar Wright");

            //creating the actual list
            movies.Add(TSR);
            movies.Add(CA);
            movies.Add(RO);
            movies.Add(LOTR);
            movies.Add(HF);

            DisplayMenu();

            string choice = ("");
            while (choice != "exit")
            {
                choice = GetString("\nMenu selection: ");
                Console.WriteLine();
                //evaluate command
                //perform action
                switch (choice)
                {
                    case "menu":
                        DisplayMenu();
                        break;

                    case "list":
                        ShowMovies();
                        break;

                    case "add":
                        AddMovie();
                        break;

                    case "get":
                        int movieNum;
                        ViewMovie();
                        break;

                    case "del":
                        movieNum = DelMovie();
                        break;

                    case "exit":
                        break;

                    default:
                        Console.WriteLine("Selection invalid.  Please try again.");
                        break;
                }
            }



            Console.WriteLine("Transcend conventions!");
        }

        //show menu
        private static void DisplayMenu()
        {
            Console.WriteLine("MENU OPTIONS:\n" +
                "Menu - Display menu\n" +
                "List - List all movies\n" +
                "Add - Add a movie\n" +
                "Get - View a movie by ID\n" +
                "Del- Delete a movie\n" +
                "Exit - Exit program");
        }

        private static int DelMovie()
        {
            int movieNum;
            //drop: prompt user for item number, remove item number from list, display confirmation (name)
            Console.WriteLine("Delete a movie");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~");
            movieNum = GetInt("Movie number to remove: ", 1, movies.Count());
            Movie delMovie = movies[movieNum - 1];
            movies.Remove(delMovie);
            Console.WriteLine($"{delMovie} was dropped into the ether.");
            return movieNum;
        }

        private static void ViewMovie()
        {
           int movieNum;
            Console.WriteLine("View a movie");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~");
            movieNum = GetInt("Movie number to view: ", 1, movies.Count());
            Movie showMovie = movies[movieNum - 1];
            Console.WriteLine($"Movie information: {showMovie}");
        }

        private static void AddMovie()
        {
            //grab: add an item (limit # of items to 4)
            Console.WriteLine("Grabbing from the ether");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~");
            Console.Write("New movie ID: ");
            int newID = int.Parse(Console.ReadLine());
            Console.Write("New movie title: ");
            string newTitle = (Console.ReadLine());
            Console.Write("New movie release year: ");
            int newYear = int.Parse(Console.ReadLine());
            Console.Write("New movie rating: ");
            string newRating = (Console.ReadLine());
            Console.Write("New movie director: ");
            string newDirector = (Console.ReadLine());
            Movie newMovie = new Movie(newID, newTitle,  newYear, newRating, newDirector);
            movies.Add(newMovie);
                Console.WriteLine($"{newTitle} was added.");
            
        }

        private static void ShowMovies()
        {
            Console.WriteLine("Current Movies");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~");
            for (int i = 0; i < movies.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i]}");
            }
        }


        //GetInt - checking when user has to enter ints
        private static int GetInt(string prompt, int min, int max)
        {
            int number = 0;
            Boolean isValid = false;

            while (!isValid)
            {
                try
                {
                    Console.Write(prompt);
                    number = int.Parse(Console.ReadLine());
                    if (number < min)
                    {
                        Console.WriteLine($"Invalid entry: number must be greater than {min}.");
                        continue;
                    }
                    else if (number > max)
                    {
                        Console.WriteLine($"Invalid entry: number must be less than {max}.");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry: please enter a valid number.");
                    continue;
                }
            }

            return number;
        }


        //prompts for strings
        private static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }
    
    }
}
