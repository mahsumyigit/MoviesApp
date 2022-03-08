public class Movie
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<MovieDetail> movieDetail{ get; set; }
}