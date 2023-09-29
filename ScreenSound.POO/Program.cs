using ScreenSound.POO;

var song = new Song
{
    name = "Strawberry Fields Forever",
    artist = "The Beatles",
    duration = 245,
    available = false
};

var song1 = new Song
{
    name = "Stairway to heaven",
    artist = "Led Zeppelin",
    duration = 482,
    available = true
};

song.ShowSongInformation();
song1.ShowSongInformation();