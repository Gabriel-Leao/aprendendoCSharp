namespace ScreenSound.POO;

public class Song
{
    public string name { get; set; }
    public string artist { get; set; }
    public int duration { get; set; }
    public bool available { get; set; }

    public void ShowSongInformation()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Artista: {artist}");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine(available
            ? $"The song, {name}, is available to listen"
            : $"The song, {name}, is not available to listen");
    }
}