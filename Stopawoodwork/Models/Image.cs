using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stopawoodwork.Models
{
    [Table("Image")]
    public class Image
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "CreatedAt is required")]
        public string Path { get; set; }

        [ForeignKey(nameof(Album))]
        public int AlbumId { get; set; }
        public Album Album { get; set; }

        [Required(ErrorMessage = "TitleImage is required")]
        public bool TitleImage { get; set; }

        [Required(ErrorMessage = "Thumbnail is required")]
        public byte[] Thumbnail { get; set; }
        
    }
}
