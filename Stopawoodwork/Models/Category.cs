using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stopawoodwork.Models
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Order is required")]
        public int Order { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}
