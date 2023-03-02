using Movies.Blazor.Shared.Entities;

namespace Movies.Blazor.Client.Helpers
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}
