namespace ScreenSound.POO;

public class Album
{
    public Album(string name)
    {
        Name = name;
    }

    private readonly List<Song> _songsList = new();

    public string Name { get; }

    private int TotalDuration => _songsList.Sum(song => song.Duration);

    public void AddSong(Song song)
    {
        _songsList.Add(song);
    }

    public void ShowSongs()
    {
        Console.WriteLine($"Lista de músicas do album {Name}:\n");
        foreach (var song in _songsList)
        {
            Console.WriteLine(song.Name);
        }

        Console.WriteLine($"\nEste albúm tem {TotalDuration} segundos de duração");
    }
}