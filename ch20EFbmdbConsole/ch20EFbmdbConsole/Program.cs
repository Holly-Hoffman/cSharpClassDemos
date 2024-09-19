using ch20EFbmdbConsole.Db;
using ch20EFbmdbConsole.Models;

namespace ch20EFbmdbConsole
{
    internal class Program
    {
        static MovieDb movieDb = new();
        static ActorDb actorDb = new();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Entity Framework, the BMDB Manager!\n");
            Console.WriteLine("Please type EXIT at any time to exit the program.\n");
            string command = "";
            command = PromptInput("Would you like to interact with movie data or actor data? (m/a): ");

            while (command != "exit")
            {

                if (command == "m")
                {
                    DisplayMovieMenu();

                    while (command != "exit")
                    {
                        command = PromptInput("Command: ");
                        switch (command)
                        {
                            case "list":
                                ListMovies();
                                break;
                            case "get":
                                GetMovie();
                                break;
                            case "add":
                                AddMovie();
                                break;
                            case "del":
                                DeleteMovie();
                                break;
                            case "exit":
                                break;
                            default:
                                Console.WriteLine("Invalid command. Try again.");
                                break;
                        }

                    }
                }

                else if (command == "a")
                {
                    DisplayActorMenu();

                    while (command != "exit")
                    {
                        command = PromptInput("Command: ");
                        switch (command)
                        {
                            case "list":
                                ListActors();
                                break;
                            case "get":
                                GetActor();
                                break;
                            case "add":
                                AddActor();
                                break;
                            case "del":
                                DeleteActor();
                                break;
                            case "exit":
                                break;
                            default:
                                Console.WriteLine("Invalid command. Try again.");
                                break;
                        }

                    }
                }

                else { Console.WriteLine("Invalid command.");}

            }
            Console.WriteLine("Bye!");
        }


        //code for actors
        private static void ListActors()
        {
            Console.WriteLine("\nActors List:");
            Console.WriteLine("============");
            //do the thing!
            List<Actor> actors = actorDb.GetActors();
            foreach (Actor actor in actors)
            {
                Console.WriteLine(actor);
            }

        }

        private static void GetActor()
        {
            Console.WriteLine("\nGet an Actor by ID:");
            Console.WriteLine("==================");
            //do the thing!
            int id = Int32.Parse(PromptInput("Actor ID: "));
            Actor a = actorDb.FindActor(id);
            if (a != null)
            {
                Console.WriteLine($"Actor found: {a}");
            }
            else
            {
                Console.WriteLine($"No actor found for ID {id}");
            }
        }

        private static void AddActor()
        {
            Console.WriteLine("\nAdd an Actor:");
            Console.WriteLine("=============");
            //do the thing!
            string firstName = PromptInput("Actor First Name: ");
            string lastName = PromptInput("Actor Last Name: ");
            string gender = PromptInput("Gender: ");
            DateOnly birthdate = DateOnly.Parse(PromptInput("Birthdate: "));
            Actor a = new Actor(firstName, lastName, gender, birthdate);
            actorDb.AddActor(a);
            Console.WriteLine($"Actor {a} has been added to the list.");
        }

        private static void DeleteActor()
        {
            Console.WriteLine("\nDelete an Actor by ID:");
            Console.WriteLine("======================");
            //do the thing!

            int id = Int32.Parse(PromptInput("Movie ID: "));
            Actor a = actorDb.FindActor(id);
            if (a != null)
            {
                actorDb.RemoveActor(a);
                Console.WriteLine($"Actor deleted.");
            }
            else
            {
                Console.WriteLine($"No actor found for ID {id}");
            }

        }

        static void DisplayActorMenu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("============");
            Console.WriteLine("list - list all actors");
            Console.WriteLine("get - get an actor by ID");
            Console.WriteLine("add - add an actor to the list");
            Console.WriteLine("del - remove an actor from the list");
            Console.WriteLine("exit - exit application");
        }

        //code for movies
        private static void ListMovies()
        {
            Console.WriteLine("\nMovies List:");
            Console.WriteLine("============");
            //do the thing!
            List<Movie> movies = movieDb.GetMovies();
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie);
            }

        }

        private static void GetMovie()
        {
            Console.WriteLine("\nGet a Movie by ID:");
            Console.WriteLine("==================");
            //do the thing!
            int id = Int32.Parse(PromptInput("Movie ID: "));
            Movie m = movieDb.FindMovie(id);
            if (m != null)
            {
                Console.WriteLine($"Movie found: {m}");
            }
            else
            {
                Console.WriteLine($"No movie found for ID {id}");
            }
        }

        private static void AddMovie()
        {
            Console.WriteLine("\nAdd a Movie:");
            Console.WriteLine("=============");
            //do the thing!
            string title = PromptInput("Movie Title: ");
            short year = short.Parse(PromptInput("Release Year: "));
            string rating = PromptInput("Rating: ");
            string director = PromptInput("Director: ");
            Movie m = new Movie(title, year, rating, director);
            movieDb.AddMovie(m);
            Console.WriteLine($"Movie {m} has been added to the list.");
        }

        private static void DeleteMovie()
        {
            Console.WriteLine("\nDelete a Movie by ID:");
            Console.WriteLine("======================");
            //do the thing!

            int id = Int32.Parse(PromptInput("Movie ID: "));
            Movie m = movieDb.FindMovie(id);
            if (m != null)
            {
                movieDb.RemoveMovie(m);
                Console.WriteLine($"Movie deleted.");
            }
            else
            {
                Console.WriteLine($"No movie found for ID {id}");
            }

        }

        static void DisplayMovieMenu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("============");
            Console.WriteLine("list - list all movies");
            Console.WriteLine("get - get a movie by ID");
            Console.WriteLine("add - add a movie to the list");
            Console.WriteLine("del - remove a movie from the list");
            Console.WriteLine("exit - exit application");
        }

        static string PromptInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }
    }
}
