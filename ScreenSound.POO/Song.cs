namespace ScreenSound.POO;

public class Song
{
    public Song(string name, Band artist)
    {
        Name = name;
        Artist = artist;
    }

    public string Name { get;  }
    private Band Artist { get;  }
    public int Duration { get; init; }
    public bool Available { get; init; }

    public Genre Genre { get; init; } = null!;

    public string Description => $"The song {Name} is from the artist {Artist}";

    public void ShowSongInformation()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Genre: {Genre.Name}");
        Console.WriteLine($"Duration: {Duration} seconds");
        Console.WriteLine(Available
            ? $"The song, {Name}, is available to listen"
            : $"The song, {Name}, is not available to listen");
    }
}