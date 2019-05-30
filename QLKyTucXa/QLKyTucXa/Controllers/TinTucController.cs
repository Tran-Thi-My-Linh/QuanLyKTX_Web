using Model.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKyTucXa.Controllers
{
    public class TinTucController : Controller
    {
        // GET: TinTuc
        public ActionResult Index(int id)
        {
            var dal = new BaiVietDAL();
            var model = dal.Detail(id);
            return View(model);
        }
    }
}