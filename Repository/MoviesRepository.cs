public class MoviesRepository : IMovieRepository
{

    MovieContext _movieContext;

    public MoviesRepository(MovieContext movieContext)
    {
        _movieContext = movieContext;
    }

    public async Task<Movie> CreateMovie(Movie movie)
    {
        try
        {
            await _movieContext.Set<Movie>.AddAsync(movie);
            await _movieContext.SaveChangesAsync();
            return movie;
        }
        catch (Exception ex)
        {
            return null;

        }
    }

    public async Task<Movie> DeleteMovie(int id)
    {
        try
        {
            var findMovie = await _movieContext.Movies.FirstOrDefault(m => m.Id == id);
            _movieContext.Movies.Remove(findMovie);
            _movieContext.SaveChangesAsync();
            return null;
        }
        catch (Exception ex)
        {

            return null;


        }
    }

    public async Task<MovieDetail> FindMovieByDirector(string director)
    {
        try
        {
            return await _movieContext.Set<MovieDetail>().FirstOrDefaultAsync(m => m.Director == director);
        }
        catch (Exception ex)
        {
            return null;
        }

    }

    public async Task<Movie> FindMovieByName(string name)
    {
        try
        {
            return await _movieContext.Set<Movie>().FirstOrDefaultAsync(m => m.Name == name);
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<Movie> FindMovieById(int id)
    {
        try
        {
            return await _movieContext.Set<Movie>().FirstOrDefaultAsync(m => m.Name == name);
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<MovieDetail> FindMovieByType(Type type)
    {
        try
        {
            return await _movieContext.Set<Movie>().FirstOrDefaultAsync(m => m.Type == type);
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<MovieDetail> FindMovieByYear(string movieYear)
    {
        try
        {
            return await _movieContext.Set<Movie>().FirstOrDefaultAsync(m => m.year == movieYear);
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<List<Movie>> GetAllMovie()
    {
        try
        {
            return await _movieContext.Set<Movie>().ToListAsync();
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<List<Movie>> GetAllMovieSortByRatings()
    {
        // tekrar bakılacak
        try
        {
            var allMoviesSorting = await _movieContext.Set<MovieDetail>().OrderByDescending(m =>m.Rating).ToListAsync();
            if (allMoviesSorting != null)
            {
                return allMoviesSorting;
            }
            return null;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<Movie> GetMovie(int id)
    {
        try
        {
            var getMovie = await _movieContext.Set<Movie>().SingleOrDefaultAsync(m=>m.Id == id);

            if (getMovie != null)
            {

                return getMovie;

            }
            else
            {
                return null;
            }
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<Movie> UpdateMovie(int Id, Movie movie)
    {
          // tekrar bakılacak
        try
        {
            var movieEdit = await _movieContext.Movie.FindAsync(id);
            movieEdit.Name = movie.Name;
    

            await _movieContext.SaveChangesAsync();
            return movieEdit;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
