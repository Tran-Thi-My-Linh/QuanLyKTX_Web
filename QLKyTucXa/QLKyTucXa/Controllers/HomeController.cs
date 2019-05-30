using Model.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKyTucXa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dal = new BaiVietDAL();
            var bv = dal.DanhSachBV().ToList();
            return View(bv);
        }

        //[ChildActionOnly]
        //public PartialViewResult MainMenu()
        //{
        //    var menu = new MenuDAL().ListMenu().ToList();
        //    return PartialView(menu);
        //}
    }
}