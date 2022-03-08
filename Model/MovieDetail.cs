public class MovieDetail
{
    public int Id { get; set; }
    public string Detail { get; set; }
    public enum Genre { SciFi,Comedy,Action,Fantasy,Horror,Crime,Adventure,Romance }
    public Genre Type {get;set;}
    public int MovieId { get; set; }
    public  Movie Movie { get; set; }
public string Director { get; set; }
public string Language { get; set; }
public string MovieYear { get; set; }
public double Ratings { get; set; }
}