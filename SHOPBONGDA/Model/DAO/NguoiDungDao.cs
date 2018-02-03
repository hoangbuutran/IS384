using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using SHOPBONGDA.Models;

namespace Model.DAO
{
    public class NguoiDungDao
    {
        ShopDbContext db = new ShopDbContext();

        public List<NGUOIDUNG> ListNguoiDung()
        {
            return db.NGUOIDUNGs.ToList();
        }
        public List<LOAINGUOIDUNG> ListLoaiNguoiDung()
        {
            return db.LOAINGUOIDUNGs.ToList();
        }

        public NGUOIDUNG NguoiDungSingleWithTenDangNhap(string tendangnhap)
        {
            return db.NGUOIDUNGs.Where(x => x.TENNGUOIDUNG == tendangnhap).SingleOrDefault();
        }

        public int Login(string tendangnhap, string matkhau)
        {
            int nguoidung = 0;

            nguoidung = db.NGUOIDUNGs.Count(x => x.TENNGUOIDUNG == tendangnhap && x.MATKHAU == matkhau);
            if (nguoidung != 0)
            {
                return 1;
            }
            return 0;
        }

        public NGUOIDUNG NguoiDungSingleWithID(int id)
        {
            return db.NGUOIDUNGs.Where(x => x.IDNGUOIDUNG == id).SingleOrDefault();
        }

        public int AddNguoiDung(NGUOIDUNG nguoidung)
        {
            int i = 0;
            try
            {
                db.NGUOIDUNGs.Add(nguoidung);
                db.SaveChanges();
                i = nguoidung.IDNGUOIDUNG;
            }
            catch (Exception)
            {
                throw;
            }
            return i;
        }

        public int EditNguoiDung(NGUOIDUNG nguoidungmoi)
        {
            int i = 0;
            try
            {
                var nguoidungcu = db.NGUOIDUNGs.Find(nguoidungmoi.IDNGUOIDUNG);
                nguoidungcu.TENNGUOIDUNG = nguoidungmoi.TENNGUOIDUNG;
                nguoidungcu.MATKHAU = nguoidungmoi.MATKHAU;
                nguoidungcu.SDT = nguoidungmoi.SDT;
                nguoidungcu.IDLOAINGUOIDUNG = nguoidungmoi.IDLOAINGUOIDUNG;
                nguoidungcu.EMAIL = nguoidungmoi.EMAIL;
                nguoidungcu.TRANGTHAI = nguoidungmoi.TRANGTHAI;
                db.SaveChanges();
                i = 1;
            }
            catch (Exception)
            {

                throw;
            }
            return i;
        }
        public int KhoaNguoiDung(int id)
        {
            int i = 0;
            try
            {
                var nguoidungcu = db.NGUOIDUNGs.Find(id);
                nguoidungcu.TENNGUOIDUNG = nguoidungcu.TENNGUOIDUNG;
                nguoidungcu.MATKHAU = nguoidungcu.MATKHAU;
                nguoidungcu.SDT = nguoidungcu.SDT;
                nguoidungcu.IDLOAINGUOIDUNG = nguoidungcu.IDLOAINGUOIDUNG;
                nguoidungcu.EMAIL = nguoidungcu.EMAIL;
                nguoidungcu.TRANGTHAI = false;
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
