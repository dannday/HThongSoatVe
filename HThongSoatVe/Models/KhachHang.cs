namespace HThongSoatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_khachhang { get; set; }

        [StringLength(10)]
        public string ten { get; set; }

        public int? cccd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        [StringLength(10)]
        public string id_ve { get; set; }
    }
}
