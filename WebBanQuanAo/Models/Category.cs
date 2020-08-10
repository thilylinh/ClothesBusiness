using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanQuanAo.Models
{
    public class Category
    {
        [Key]
        public string CategoryID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
