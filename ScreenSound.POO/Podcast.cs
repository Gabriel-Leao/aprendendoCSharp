namespace ScreenSound.POO;

public class Podcast
{
    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    private string Name { get; }

    private string Host { get; }

    private readonly List<Episode> _episodes = new();

    private int TotalEpisodes => _episodes.Count;

    public void AddEpisode(Episode episode)
    {
        _episodes.Add(episode);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"O podcast: {Name}, é apresentado por {Host}\n");
        Console.WriteLine("Episódios:");
        foreach (var episode in _episodes.OrderBy(ep => ep.Order))
        {
            Console.WriteLine(episode.Resume);
        }

        Console.WriteLine($"\nEsse podcast possui {(TotalEpisodes == 0 ? "nenhum episódio": TotalEpisodes > 1 ? $"{TotalEpisodes} episódios": "1 episódio")}");
    }
}