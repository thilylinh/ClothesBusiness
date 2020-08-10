using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanQuanAo.Models
{
    public class Producer
    { 

        [Key]
        public string ProducerID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Adress { get; set; }
        public int PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress )]
        public string Email { get; set; }
        public ICollection<ImportProduct> ImportProducts { get; set; }
    }
}
