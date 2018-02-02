using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class LoaiSanPhamDao
    {
        ShopDbContext db = new ShopDbContext();

        public List<LOAISANPHAM> ListSanPham()
        {
            return db.LOAISANPHAMs.ToList();
        }

        public LOAISANPHAM SanPhamSingleWithID(int id)
        {
            return db.LOAISANPHAMs.Where(x => x.IDLOAISANPHAM == id).SingleOrDefault();
        }

        public int AddLoaiSanPham(LOAISANPHAM loaisanpham)
        {
            int i = 0;
            try
            {
                db.LOAISANPHAMs.Add(loaisanpham);
                db.SaveChanges();
                i = loaisanpham.IDLOAISANPHAM;
            }
            catch (Exception)
            {
                throw;
            }
            return i;
        }

        public int EditLoaiSanPham(LOAISANPHAM loaisanphammoi)
        {
            int i = 0;
            try
            {
                var sanphamcu = db.LOAISANPHAMs.Find(loaisanphammoi.IDLOAISANPHAM);
                sanphamcu.TENLOAISANPHAM = loaisanphammoi.TENLOAISANPHAM;
                sanphamcu.TRANGTHAI = loaisanphammoi.TRANGTHAI;
                db.SaveChanges();
                i = 1;
            }
            catch (Exception)
            {

                throw;
            }
            return i;
        }

        public int DeleteLoaiSanPham(int id)
        {
            int i = 0;
            try
            {
                var sanpham = db.LOAISANPHAMs.Find(id);
                db.LOAISANPHAMs.Remove(sanpham);
                db.SaveChanges();
                i = 1;
            }
            catch (Exception)
            {

                throw;
            }
            return i;
        }
    }
}
