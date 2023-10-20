namespace ScreenSound2._0.Models;

class Band
{
    private readonly List<Album> _albums = new List<Album>();
    private readonly List<int> _grades = new List<int>();

    public Band(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public double Average => _grades.Average();
    public List<Album> Albums => _albums;

    public void AddAlbum(Album album) 
    { 
        _albums.Add(album);
    }

    public void AddGrade(int nota)
    {
        _grades.Add(nota);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Discografia da banda {Name}");
        foreach (var album in _albums)
        {
            Console.WriteLine($"Álbum: {album.Name} ({album.TotalDuration})");
        }
    }
}