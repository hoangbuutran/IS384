using Model.DAO;
using Model.EF;
using SHOPBONGDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SHOPBONGDA.Controllers
{
    public class TaiKhoanController : Controller
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
                return RedirectToAction("Index","TrangChu");
            }
            return View();
        }

        // GET: TaiKhoan/Details/5
        public ActionResult Details(int id)
        {
            var dao = new NguoiDungDao();
            return View(dao.NguoiDungSingleWithID(id));
        }

        // GET: TaiKhoan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaiKhoan/Create
        [HttpPost]
        public ActionResult Create(NGUOIDUNG nguoidung, FormCollection collection)
        {
            try
            {
                var dao = new NguoiDungDao();
                if (dao.AddNguoiDung(nguoidung) != 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "loi");
                }
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: TaiKhoan/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TaiKhoan/Edit/5
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
