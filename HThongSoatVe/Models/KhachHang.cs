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

        [StringLength(50)]
        public string ten { get; set; }

        public DateTime ngaysinh { get; set; }

        public string sdt { get; set; }

        [StringLength(50)]
        public string pass { get; set; }
    }
}
