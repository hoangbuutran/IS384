namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOIDUNG")]
    public partial class NGUOIDUNG
    {
        public NGUOIDUNG()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        public int IDNGUOIDUNG { get; set; }

        [StringLength(100)]
        public string TENNGUOIDUNG { get; set; }

        [StringLength(50)]
        public string MATKHAU { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(150)]
        public string EMAIL { get; set; }

        public bool? TRANGTHAI { get; set; }

        public int? IDLOAINGUOIDUNG { get; set; }

        public virtual ICollection<HOADON> HOADONs { get; set; }

        public virtual LOAINGUOIDUNG LOAINGUOIDUNG { get; set; }
    }
}
