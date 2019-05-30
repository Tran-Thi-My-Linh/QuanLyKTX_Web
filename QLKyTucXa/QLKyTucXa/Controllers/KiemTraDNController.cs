using QLKyTucXa.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QLKyTucXa.Controllers
{
    public class KiemTraDNController : Controller
    {
        // GET: KiemTraDN
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = Session["TenSinhVien"];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(new { controller = "DangNhap", action = "Index" }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}