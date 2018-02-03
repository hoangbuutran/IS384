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
            return View();
        }

        
        // GET: Admin/Nguoidung/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Nguoidung/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
    }
}
