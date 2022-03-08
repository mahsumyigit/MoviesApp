public interface IMovieRepository
{
    Task<List<Movie>> GetAllMovie();
    Task<Movie> GetMovie(int Id);
    Task<List<Movie>> FindMovieByName(string name);
    Task<Movie> FindMovieById(int id);
    Task<List<MovieDetail>> FindMovieByYear(string movieYear);
    Task<List<MovieDetail>> FindMovieByType(Type type);
    Task<List<MovieDetail>> FindMovieByDirector(string director);
    Task<List<MovieDetail>> GetAllMovieSortByRatings();
    Task<Movie> CreateMovie(Movie movie);
    Task<Movie> DeleteMovie(Movie movie);
    Task<Movie> UpdateMovie(int Id,Movie movie);
    }