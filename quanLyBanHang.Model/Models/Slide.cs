﻿using System;
using System.Collections.Generic;
using System.Text;

namespace quanLyBanHang.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        public string Description { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        [MaxLength(256)]
        public string Url { set; get; }

        public int? DisplayOrder { set; get; }

        public bool Status { set; get; }

        public string Content { set; get; }
    }
}