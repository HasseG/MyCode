using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Album> Albums { get; set; }
        public ICollection<Song> Songs { get;}
    }
}
