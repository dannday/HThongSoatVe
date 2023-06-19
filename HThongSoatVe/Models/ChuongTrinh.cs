namespace HThongSoatVe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuongTrinh")]
    public partial class ChuongTrinh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_chuongtrinh { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        [StringLength(50)]
        public string hinhanh { get; set; }

        [StringLength(50)]
        public string diadiem { get; set; }

        [StringLength(50)]
        public string mota { get; set; }
    }
}
