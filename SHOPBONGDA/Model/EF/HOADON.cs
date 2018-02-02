namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        public HOADON()
        {
            CTHOADONs = new HashSet<CTHOADON>();
        }

        [Key]
        public int IDHOADON { get; set; }

        public DateTime? NGAYLAPHOADON { get; set; }

        public bool? TRANGTHAI { get; set; }

        public int? IDNGUOIDUNG { get; set; }

        public virtual ICollection<CTHOADON> CTHOADONs { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
    }
}
