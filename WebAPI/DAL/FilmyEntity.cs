namespace DAL
{
    public class FilmyEntity
    {
    public int ID { get; set; }
    public required string Tytul { get; set; }
    public required string Rezyser { get; set; }
    public required string Gatunek { get; set; }
    public int Rok_wydania { get; set; }
    }
}
