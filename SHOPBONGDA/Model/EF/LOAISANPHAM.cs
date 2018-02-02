namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAISANPHAM")]
    public partial class LOAISANPHAM
    {
        public LOAISANPHAM()
        {
            SANPHAMs = new HashSet<SANPHAM>();
        }

        [Key]
        public int IDLOAISANPHAM { get; set; }

        [StringLength(150)]
        public string TENLOAISANPHAM { get; set; }

        public bool? TRANGTHAI { get; set; }

        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}
