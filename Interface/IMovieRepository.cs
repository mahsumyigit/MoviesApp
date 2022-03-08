public interface IMovieRepository
{
    Task<List<Movie>> GetAllMovie();
    Task<Movie> GetMovie(int Id);
    Task<Movie> FindMovieByName(string Name);
    Task<MovieDetail> FindMovieByYear(string MovieYear);
    Task<MovieDetail> FindMovieByType(Type type);
    Task<MovieDetail> FindMovieByDirector(string Director);
    Task<MovieDetail> GetAllMovieSortByRatings(double Ratings);
    }