namespace bmdbIO.models
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
            Id = id;
            Title = title;
            Year = year;
            Rating = rating;
            Director = director;
        }

        public override string ToString()
        {
            return $"Movie: ID - '{Id}', title - '{Title}', year - '{Year}', rating - '{Rating}', director - '{Director}'";
        }

    }
}
