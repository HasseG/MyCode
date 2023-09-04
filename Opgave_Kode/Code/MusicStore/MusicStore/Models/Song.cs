using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }
        public int AlbumId { get; set; }
        public int ArtistId {  get; set; }
        public double Duration { get; set; }
        [Required]
        public string Title { get; set; }
        public Album Album { get; set; }
        public Artist Artist { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}
