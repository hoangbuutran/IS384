using System.Web.Mvc;

namespace SHOPBONGDA.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "SanPhamController",
                "Admin/SanPham/{action}/{id}",
                new { action = "Index", controller = "SanPham", id = UrlParameter.Optional }
            );
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", controller = "Home", id = UrlParameter.Optional }
            );
        }
    }
}