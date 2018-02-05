using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SHOPBONGDA.Areas.Admin.Controllers
{
    public class HomeController : RangBuocController
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            var daoNguoiDung = new NguoiDungDao().ListNguoiDung();
            var daoSanPham = new SanPhamDao().ListSanPham();
            var daoHoaDon = new HoaDonDao().ListHoaDon();
            ViewBag.nguoidung = daoNguoiDung.Count;
            ViewBag.sanpham = daoSanPham.Count;
            ViewBag.hoadon = daoHoaDon.Count;
            return View();
        }
    }
}