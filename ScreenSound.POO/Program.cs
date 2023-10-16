using ScreenSound.POO;

var beatles = new Band("Beatles");

var song1 = new Song("With a Little Help from My Friends", beatles)
{
    Duration = 160,
    Available = true,
    Genre = new Genre("Rock")
};

var song2 = new Song("A day in the life", beatles)
{
    Duration = 299,
    Available = false,
    Genre = new Genre("Rock")
};

var sgtPeppersLonelyHeartsClubBand = new Album("Sgt Peppers Lonely Hearts Club Band");

sgtPeppersLonelyHeartsClubBand.AddSong(song1);
sgtPeppersLonelyHeartsClubBand.AddSong(song2);
beatles.AddAlbum(sgtPeppersLonelyHeartsClubBand);

sgtPeppersLonelyHeartsClubBand.ShowSongs();
beatles.ShowDiscography();

var podcast = new Podcast("Dev podcast", "Gabriel Leão");
var episode1 = new Episode("Ep1", 80, 1);
var episode2 = new Episode("Ep2", 90, 2);

episode1.AddGuest("Gabriel");
episode1.AddGuest("Leão");
podcast.AddEpisode(episode2);
podcast.AddEpisode(episode1);
podcast.ShowDetails();