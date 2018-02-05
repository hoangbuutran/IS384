using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class HoaDonDao
    {
        ShopDbContext db = new ShopDbContext();

        public List<HOADON> ListHoaDon()
        {
            return db.HOADONs.ToList();
        }

        public HOADON HoaDonSingleWithID(int id)
        {
            return db.HOADONs.Where(x => x.IDHOADON == id).SingleOrDefault();
        }

        public HOADON ThemHoaDon(int id)
        {
            var hoadon = new HOADON();
            hoadon.NGAYLAPHOADON = DateTime.Now;
            hoadon.TRANGTHAI = true;
            hoadon.IDNGUOIDUNG = id;
            db.HOADONs.Add(hoadon);
            db.SaveChanges();
            return hoadon;
        }
        public int ThemCTHoaDon(int idhoadon, int idsanpham, int soluong, int gia)
        {
            var cthoadon = new CTHOADON();
            cthoadon.IDHOADON = idhoadon;
            cthoadon.IDSANPHAM = idsanpham;
            cthoadon.SOLUONG = soluong;
            cthoadon.GIA = gia;
            db.CTHOADONs.Add(cthoadon);
            db.SaveChanges();
            return 0;
        }
    }
}
