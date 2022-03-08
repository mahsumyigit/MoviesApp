public class MovieService : IMovieService
{
    public Task<Movie> CreateMovie(Movie movie)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> DeleteMovie(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<MovieDetail> FindMovieByDirector(string Director)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> FindMovieByName(string Name)
    {
        throw new NotImplementedException();
    }

    public Task<MovieDetail> FindMovieByType(Type type)
    {
        throw new NotImplementedException();
    }

    public Task<MovieDetail> FindMovieByYear(string MovieYear)
    {
        throw new NotImplementedException();
    }

    public Task<List<Movie>> GetAllMovie()
    {
        throw new NotImplementedException();
    }

    public Task<MovieDetail> GetAllMovieSortByRatings(double Ratings)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> GetMovie(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> UpdateMovie(int Id, Movie movie)
    {
        throw new NotImplementedException();
    }
}
