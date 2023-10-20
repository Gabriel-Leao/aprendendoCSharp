namespace ScreenSound2._0.Models;

class Song
{
    public Song(Band artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    public string Name { get; }
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public string ResumeDescription => $"A música {Name} pertence à banda {Artist}";

    public void ShowTecnicalInfo()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Artista: {Artist.Name}");
        Console.WriteLine($"Duração: {Duration}");
        Console.WriteLine(Available ? "Disponível no plano." : "Adquira o plano Plus+");
    }
}