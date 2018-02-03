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
    }
}
