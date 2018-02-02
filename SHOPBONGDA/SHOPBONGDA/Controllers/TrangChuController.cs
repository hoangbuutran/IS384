using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SHOPBONGDA.Controllers
{
    public class TrangChuController : Controller
    {
        SanPhamDao daoSanPham = null;
        LoaiSanPhamDao daoLoaiSanPham = null;

        public TrangChuController()
        {
            daoSanPham = new SanPhamDao();
            daoLoaiSanPham = new LoaiSanPhamDao();
        }
        // GET: TrangChu
        public ActionResult Index()
        {
            ViewBag.DsSanPham = daoSanPham.ListSanPham();
            return View(daoLoaiSanPham.ListSanPham());
        }

        [ChildActionOnly]
        public ActionResult MenuLeft()
        {
            return PartialView(daoLoaiSanPham.ListSanPham());
        }
        public ActionResult ChiTietSanPham(int id)
        {
            return View(daoSanPham.SanPhamSingleWithID(id));
        }
        public ActionResult DanhSachSanPhamLoai(int id)
        {
            return View(daoSanPham.ListSanPhamWithID(id));
        }
    }
}