using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class Playlist
    {
        [Key]
        public int PlaylistId { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        
        public ICollection<Song> Songs { get; set;}
    }
}
