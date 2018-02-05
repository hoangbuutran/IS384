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
    public class CartController : Controller
    {
        private const string CartSession = "CartSession";

        // GET: Cart
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }

        public ActionResult AddItem(int idsanpham, int soluong)
        {
            var sanpham = new SanPhamDao().SanPhamSingleWithID(idsanpham);
            var cart = Session[CartSession];
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if (list.Exists(x => x.SanPham.IDSANPHAM == idsanpham))
                {
                    foreach (var item in list)
                    {
                        if (item.SanPham.IDSANPHAM == idsanpham)
                        {
                            item.SoLuong += soluong;
                        }
                    }
                }
                else
                {
                    var item = new CartItem();
                    item.SanPham  = sanpham;
                    item.SoLuong = soluong;
                    list.Add(item);
                }

            }
            else
            {
                /// taoj moi doi tuong cart item
                var item = new CartItem();
                item.SanPham = sanpham;
                item.SoLuong = soluong;
                var list = new List<CartItem>();
                list.Add(item);
                // gan vao session
                Session[CartSession] = list;
            }
            return RedirectToAction("Index");
        }
        public ActionResult DatHang()
        {
            var list = new List<CartItem>();
            var nguoidung = (LoginModel)Session["USER_SESSION"];
            var hoadon = new HoaDonDao().ThemHoaDon(nguoidung.id);
            //var cthoadon = new CTHOADON()
            return View(list);
        }
    }
}