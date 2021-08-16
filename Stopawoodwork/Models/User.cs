using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stopawoodwork.Models
{
    [Table("User")]
    public class User
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "TitleImage is required")]
        public string UserName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "TitleImage is required")]
        public string Password { get; set; }
    }
}
