using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanQuanAo.Models
{
    public class ImportProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImportID { get; set; }
        public string ProductID { get; set; }
        public string ProducerID { get; set; }
        
        public Product Product { get; set; }
        public Producer Producer { get; set; }
    }
}
