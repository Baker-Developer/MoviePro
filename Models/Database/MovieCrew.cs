namespace MoviePro.Models.Database
{
    public class MovieCrew
    {
        public int Id { get; set; }
        public string TMDBmovieId { get; set; }
        public int TMDBcrewId { get; set; }
        public string Department { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string ImageUrl { get; set; }

        public Movie Movie { get; set; }
    }
}
