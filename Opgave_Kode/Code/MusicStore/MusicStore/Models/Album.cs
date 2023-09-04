using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string AlbumURLName { get; set; }

        public Artist Artist { get; set; }
        public Genre Genre { get; set; }

        public ICollection<Song> Songs { get; set; }

    }
}
