using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace quanLyBanHang.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Column(Order = 1)]
        public int OrderID { set; get; }

        [Column(Order = 2)]
        public int ProductID { set; get; }

        public int Quantity { set; get; }

        public int Price { set; get; }

        [ForeignKey("OrderID")]

        public virtual Order Order { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
    }
}