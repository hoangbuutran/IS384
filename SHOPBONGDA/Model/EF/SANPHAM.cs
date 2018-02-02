namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        public SANPHAM()
        {
            CTHOADONs = new HashSet<CTHOADON>();
        }

        [Key]
        public int IDSANPHAM { get; set; }

        [StringLength(150)]
        public string TENSANPHAM { get; set; }

        public int? GIA { get; set; }

        [StringLength(100)]
        public string HINHANH { get; set; }

        public DateTime? NGAY { get; set; }

        [StringLength(50)]
        public string MAUSAC { get; set; }

        [StringLength(150)]
        public string XUATXU { get; set; }

        [Column(TypeName = "ntext")]
        public string MIEUTA { get; set; }

        public bool? TRANGTHAI { get; set; }

        public int? IDLOAISANPHAM { get; set; }

        public virtual ICollection<CTHOADON> CTHOADONs { get; set; }

        public virtual LOAISANPHAM LOAISANPHAM { get; set; }
    }
}
