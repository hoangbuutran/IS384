using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SHOPBONGDA.Areas.Admin.Controllers
{
    public class NguoidungController : Controller
    {
        // GET: Admin/Nguoidung
        public ActionResult Index()
        {
            var dao = new NguoiDungDao();
            return View(dao.ListNguoiDung());
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var dao = new NguoiDungDao().NguoiDungSingleWithID(id);
            return View();
        }

        
    }
}
