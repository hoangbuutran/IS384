namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAINGUOIDUNG")]
    public partial class LOAINGUOIDUNG
    {
        public LOAINGUOIDUNG()
        {
            NGUOIDUNGs = new HashSet<NGUOIDUNG>();
        }

        [Key]
        public int IDLOAINGUOIDUNG { get; set; }

        [StringLength(50)]
        public string TENLOAINGUOIDUNG { get; set; }

        public bool? TRANGTHAI { get; set; }

        public virtual ICollection<NGUOIDUNG> NGUOIDUNGs { get; set; }
    }
}
