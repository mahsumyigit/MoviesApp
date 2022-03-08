using Microsoft.EntityFrameworkCore;

public class MovieContext:DbContext
{
   public DbSet<Movie> Movies {get;set;}
   public DbSet<MovieDetail> MovieDetails { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
        optionsBuilder.UseMySql("server=localhost;database=sahabt;user=root;port=3306;password=toortoor", serverVersion);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
          MovieDatabaseBuilder.TableBuilder(modelBuilder);
    }

   


}