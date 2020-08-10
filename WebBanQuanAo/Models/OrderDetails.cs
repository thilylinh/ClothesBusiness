using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanQuanAo.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailID { get; set; }
        public string ProductID { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName ="money")]
        public decimal Price { get; set; }
        public decimal Total { get { return Quantity * Price; } }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
