namespace ScreenSound2._0.Models;

class Album
{
    private readonly List<Song> _songs = new List<Song>();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int TotalDuration => _songs.Sum(m => m.Duration);
    public List<Song> Songs => _songs;

    public void AddSong(Song song)
    {
        _songs.Add(song);
    }

    public void ShowAlbumSongs()
    {
        Console.WriteLine($"Lista de músicas do álbum {Name}:\n");
        foreach (var song in _songs)
        {
            Console.WriteLine($"Música: {song.Name}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {TotalDuration}");
    }
}