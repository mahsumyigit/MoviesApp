using System.Collections.Generic;
public interface IMovieService
{
    Task<List<Movie>> GetAllMovie();
    Task<Movie> GetMovie(int Id);
    Task<List<Movie>> FindMovieByName(string name);
    Task<List<MovieDetail>> FindMovieByYear(string movieYear);
    Task<List<MovieDetail>> FindMovieByType(Type type);
    Task<List<MovieDetail>> FindMovieByDirector(string director);
    Task<List<MovieDetail>> GetAllMovieSortByRatings();
    Task<Movie> CreateMovie(Movie movie);
    Task<Movie> DeleteMovie(int id);
    Task<Movie> UpdateMovie(int id,Movie movie);
    }