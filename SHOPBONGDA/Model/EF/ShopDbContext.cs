namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopDbContext : DbContext
    {
        public ShopDbContext()
            : base("name=ShopDbContext")
        {
        }

        public virtual DbSet<CTHOADON> CTHOADONs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<LOAINGUOIDUNG> LOAINGUOIDUNGs { get; set; }
        public virtual DbSet<LOAISANPHAM> LOAISANPHAMs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
