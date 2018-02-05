using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SHOPBONGDA.Areas.Admin.Controllers
{
    public class HoaDonController : RangBuocController
    {
        // GET: Admin/HoaDon
        public ActionResult Index()
        {
            var dao = new HoaDonDao();
            return View(dao.ListHoaDon());
        }
    }
}