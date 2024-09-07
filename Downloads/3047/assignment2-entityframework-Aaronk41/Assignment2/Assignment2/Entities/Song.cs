using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2.Entities
{
    [Table("Music")]
    public class Song
    {
        public int songId { get; set; }
        [MaxLength(50)]
        public string albumName { get; set; }
        [MaxLength(50)]
        public string songName { get; set; }
    }
}
