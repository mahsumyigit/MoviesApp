public interface IMovieService
{
    Task<List<Movie>> GetAllMovie();
    Task<Movie> GetMovie(int Id);
    Task<Movie> FindMovieByName(string Name);
    Task<MovieDetail> FindMovieByYear(string MovieYear);
    Task<MovieDetail> FindMovieByType(Type type);
    Task<MovieDetail> FindMovieByDirector(string Director);
    Task<MovieDetail> GetAllMovieSortByRatings(double Ratings);
    Task<Movie> CreateMovie(Movie movie);
    Task<Movie> DeleteMovie(int Id);
    Task<Movie> UpdateMovie(int Id,Movie movie);
    }