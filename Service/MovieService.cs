public class MovieService : IMovieService
{

    private IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<Movie> CreateMovie(Movie movie)
    {
        var existCheck = await _movieRepository.FindMovieByName(movie.Name);
        if(existCheck == null)
        {
            return await _movieRepository.CreateMovie(movie);
        }
        else{
            throw new Exception();
        }
    }

    public async Task<Movie> DeleteMovie(int id)
    {
        var existCheck = await _movieRepository.FindMovieById(id);
        if(existCheck != null)
        {
            return await _movieRepository.DeleteMovie(id);
        }
        else{
            throw new Exception();
        }
    }

    public async Task<List<MovieDetail>> FindMovieByDirector(string director)
    {
        return await _movieRepository.FindMovieByDirector(director);
    }

    public async Task<List<Movie>> FindMovieByName(string name)
    {
        return await _movieRepository.FindMovieByName(name);
    }

    public async Task<List<MovieDetail>> FindMovieByType(Type type)
    {
         return await _movieRepository.FindMovieByType(type);
    }

    public async Task<List<MovieDetail>> FindMovieByYear(string movieYear)
    {
       return await _movieRepository.FindMovieByYear(movieYear);
    }

    public async Task<List<Movie>> GetAllMovie()
    {
       return await _movieRepository.GetAllMovie();
    }

    public async Task<List<MovieDetail>> GetAllMovieSortByRatings()
    {
       return await _movieRepository.GetAllMovieSortByRatings();
    }

    public async Task<Movie> GetMovie(int Id)
    {
         if (id != null)
        {
            return await _movieRepository.GetMovie(id);

        }
        return null;
    }

    public async Task<Movie> UpdateMovie(int Id, Movie movie)
    {
      return await _movieRepository.UpdateMovie(Id, movie);
    }
}
