namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHOADON")]
    public partial class CTHOADON
    {
        [Key]
        public int IDCTHOADON { get; set; }

        public int? SOLUONG { get; set; }

        public double? GIA { get; set; }

        public int? IDHOADON { get; set; }

        public int? IDSANPHAM { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
