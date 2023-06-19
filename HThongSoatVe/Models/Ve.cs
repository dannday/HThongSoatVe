namespace HThongSoatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ve")]
    public partial class Ve
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_ve { get; set; }

        [StringLength(50)]
        public string loai { get; set; }

        public int? gia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysk { get; set; }

        public int? soluong { get; set; }

        [StringLength(50)]
        public string QRcode { get; set; }
    }
}
