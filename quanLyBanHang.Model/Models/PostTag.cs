using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace quanLyBanHang.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {   
        public int PostID { set; get; }

        [Key]
        [Column(TypeName = "varchar", Order = 2)]
        public string TagID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}