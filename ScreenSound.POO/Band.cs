namespace ScreenSound.POO;

public class Band
{
    public Band(string name)
    {
        Name = name;
    }

    private readonly List<Album> _albumns = new();

    private string Name { get; }

    public void AddAlbum(Album album)
    {
        _albumns.Add(album);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Discografia da banda: {Name}");

        foreach (var album in _albumns)
        {
            Console.WriteLine($"Álbum: {album.Name}");
        }
    }
}