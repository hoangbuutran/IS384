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

        public int ThemHoaDon(int id)
        {
            var hoadon = new HOADON();
            hoadon.NGAYLAPHOADON = DateTime.Now;
            hoadon.TRANGTHAI = true;
            hoadon.IDNGUOIDUNG = id;
            db.HOADONs.Add(hoadon);
            db.SaveChanges();
            return hoadon.IDHOADON;
        }
        //public int ThemCTHoaDon(int idhoadon, )
        //{

        //    return 0;
        //}
    }
}
