using Microsoft.EntityFrameworkCore;

public static class MovieDatabaseBuilder
{


    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
         {
             entity.HasKey(e => e.Id);
             entity.Property(e => e.Name).IsRequired();
         });


        modelBuilder.Entity<MovieDetail>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Detail);
            entity.Property(e => e.Director);
            entity.Property(e => e.Language);
            entity.Property(e => e.MovieYear);
            entity.Property(e => e.Type);
            entity.Property(e => e.Ratings);
            entity.HasOne(e => e.Movie).WithMany(e => e.movieDetail).HasForeignKey(e => e.MovieId);

        });

        modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                Id = 1,
                Name = "Titanik"
            },
            new Movie
            {
                Id = 2,
                Name = "Spider-Man"
            }
        ); 
        modelBuilder.Entity<MovieDetail>().HasData(
            new MovieDetail
            {
                Id = 1,
                Detail = "Güzel film",
                Type=MovieDetail.Genre.Action,
                MovieId=1,
                Director="Nuri Bilge Ceylan",
                Language="Tr",
                MovieYear="1998",
                Ratings=7.5
            },
            new MovieDetail
            {
                Id = 2,
                Detail = "Muhammed şeften öneriler",
                Type=MovieDetail.Genre.Fantasy,
                MovieId=2,
                Director="Peter Parker",
                Language="Eng",
                MovieYear="1990",
                Ratings=8.0

            }
            
        );

        SetDataToDB(modelBuilder);
    }
}