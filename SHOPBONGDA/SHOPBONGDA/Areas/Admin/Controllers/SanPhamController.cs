using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SHOPBONGDA.Areas.Admin.Controllers
{
    public class SanPhamController : RangBuocController
    {

        SanPhamDao daoSanPham = null;
        LoaiSanPhamDao daoLoaiSanPham = null;

        public SanPhamController()
        {
            daoSanPham = new SanPhamDao();
            daoLoaiSanPham = new LoaiSanPhamDao();
        }

        // GET: Admin/SanPham
        public ActionResult Index()
        {
            return View(daoSanPham.ListSanPham());
        }

        // GET: Admin/SanPham/Details/5
        public ActionResult Details(int id)
        {
            return View(daoSanPham.SanPhamSingleWithID(id));
        }

        // GET: Admin/SanPham/Create
        public ActionResult Create()
        {
            ViewBag.DsLoaiSanPham = new SelectList(daoLoaiSanPham.ListSanPham(), "IDLOAISANPHAM", "TENLOAISANPHAM");
            return View();
        }

        // POST: Admin/SanPham/Create
        [HttpPost]
        public ActionResult Create(SANPHAM sanpham, FormCollection collection)
        {
            try
            {
                if (daoSanPham.AddSanPham(sanpham) != 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Loi");
                }
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: Admin/SanPham/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.DsLoaiSanPham = new SelectList(daoLoaiSanPham.ListSanPham(), "IDLOAISANPHAM", "TENLOAISANPHAM");
            return View(daoSanPham.SanPhamSingleWithID(id));
        }

        // POST: Admin/SanPham/Edit/5
        [HttpPost]
        public ActionResult Edit(SANPHAM sanpham, FormCollection collection)
        {
            try
            {
                if (daoSanPham.EditSanPham(sanpham) != 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Loi");
                }
            }
            catch
            {
                return View();
            }
            return View();
        }

        public ActionResult Delete(int id, FormCollection collection)
        {
            daoSanPham.DeleteSanPham(id);
            return RedirectToAction("Index", "SanPham");
        }
    }
}
