namespace MusicStore.Models
{
    public class SongGenre
    {
        public int GenreId { get; set; }
        public int SongId { get; set; }

        public Song Song { get; set; }
        public Genre Genre { get; set; }

    }
}
