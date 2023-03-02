using Movies.Blazor.Shared.Entities;

namespace Movies.Blazor.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie(){Title = "Spider-Man: Far From Home", ReleaseDate = new DateTime(2019, 7, 2) },
                new Movie(){Title = "Moana", ReleaseDate = new DateTime(2015, 8, 21) },
                new Movie(){Title = "Inception", ReleaseDate = new DateTime(2010, 9, 7) }
            };
        }
    }
}
