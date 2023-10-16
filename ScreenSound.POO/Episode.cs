namespace ScreenSound.POO;

public class Episode
{
    public Episode(string title, int duration, int order)
    {
        Title = title;
        Duration = duration;
        Order = order;
    }

    private string Title { get; }

    public int Order { get; }

    private int Duration { get; }

    public string Resume => $"{Order}. {Title} ({Duration} min) {(_guests.Count >= 1 ? $"- {string.Join(", ", _guests)}" : string.Empty)}";

    private readonly List<string> _guests = new();

    public void AddGuest(string guest)
    {
        _guests.Add(guest);
    }
}