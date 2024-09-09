namespace bmdbManager
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Rating { get; set; }
        public string Director { get; set; }

        public Movie() { }
        public Movie(int id, string title, int year, string rating, string director)
        {
            this.Id = id;
            this.Title = title;
            this.Year = year;
            this.Rating = rating;
            this.Director = director;
        }

        public override string ToString()
        {
            return $"Movie: ID - '{this.Id}', title - '{this.Title}', year - '{this.Year}', rating - '{this.Rating}', director - '{this.Director}'";
        }
    }
}
