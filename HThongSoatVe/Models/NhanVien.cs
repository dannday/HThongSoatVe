namespace HThongSoatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_nhanvien { get; set; }

        [StringLength(50)]
        public string sdt { get; set; }

        [StringLength(50)]
        public string pass { get; set; }

        [StringLength(50)]
        public string tennhanvien { get; set; }

        [StringLength(50)]
        public string phanquyen { get; set; }
    }
}
