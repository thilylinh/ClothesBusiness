using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanQuanAo.Models
{
    public class Product
    {
        [Key]
        public string ID { get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        public string Avatar { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal PurchasePrice { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal RetailPrice { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{dd-MM-yyyy}",ApplyFormatInEditMode =true )]
        [Display(Name="Date of entry")]
        public DateTime DateEntry { get; set; }
        public string CategoryID { get; set; }
        public Category Category { get; set; }
        public ICollection<ImportProduct> ImportProducts { get; set; }
    }
}
