using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class SanPhamDao
    {
        ShopDbContext db = new ShopDbContext();

        public List<SANPHAM> ListSanPham()
        {
            return db.SANPHAMs.ToList();
        }
        public List<SANPHAM> ListSanPhamWithID(int id)
        {
            return db.SANPHAMs.Where(x => x.IDLOAISANPHAM == id).ToList();
        }
        public SANPHAM SanPhamSingleWithID(int id)
        {
            return db.SANPHAMs.Where(x => x.IDSANPHAM == id).SingleOrDefault();
        }

        public int AddSanPham(SANPHAM sanpham)
        {
            int i = 0;
            try
            {
                sanpham.NGAY = DateTime.Now;
                db.SANPHAMs.Add(sanpham);
                db.SaveChanges();
                i = sanpham.IDSANPHAM;
            }
            catch (Exception)
            {
                throw;
            }
            return i;
        }

        public int EditSanPham(SANPHAM sanphammoi)
        {
            int i = 0;
            try
            {
                var sanphamcu = db.SANPHAMs.Find(sanphammoi.IDSANPHAM);
                sanphamcu.TENSANPHAM = sanphammoi.TENSANPHAM;
                sanphamcu.GIA = sanphammoi.GIA;
                sanphamcu.HINHANH = sanphammoi.HINHANH;
                sanphamcu.NGAY = DateTime.Now;
                sanphamcu.MAUSAC = sanphammoi.MAUSAC;
                sanphamcu.XUATXU = sanphammoi.XUATXU;
                sanphamcu.MIEUTA = sanphammoi.MIEUTA;
                sanphamcu.TRANGTHAI = sanphammoi.TRANGTHAI;
                sanphamcu.IDLOAISANPHAM = sanphammoi.IDLOAISANPHAM;
                db.SaveChanges();
                i = 1;
            }
            catch (Exception)
            {

                throw;
            }
            return i;
        }

        public int DeleteSanPham(int id)
        {
            int i = 0;
            try
            {
                var sanpham = db.SANPHAMs.Find(id);
                db.SANPHAMs.Remove(sanpham);
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
