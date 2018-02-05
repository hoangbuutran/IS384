using Model.DAO;
using SHOPBONGDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SHOPBONGDA.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel user)
        {
            var dao = new NguoiDungDao();
            if (dao.Login(user.tendangnhap, user.matkhau) == 1)
            {
                var nguoidung = dao.NguoiDungSingleWithTenDangNhap(user.tendangnhap);
                var nguoidungsession = new LoginModel();
                nguoidungsession.tendangnhap = nguoidung.TENNGUOIDUNG;
                nguoidungsession.id = nguoidung.IDNGUOIDUNG;
                Session.Add("USER_SESSION", nguoidungsession);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}