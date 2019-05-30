using Model.DAL;
using QLKyTucXa.Areas.Admin.Models;
using QLKyTucXa.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKyTucXa.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dal = new NguoiDungDAL();
                //var result = dal.Login(model.IDNguoiDung, Encryptor.MD5Hash(model.MatKhau));
                var result = dal.Login(model.IDNguoiDung, model.MatKhau);
                if (result == 1)
                {
                    var nd = dal.GetByID(model.IDNguoiDung);
                    var userSession = new UserLogin();
                    userSession.IDNguoiDung = nd.IDNguoiDung;
                    userSession.TenNguoiDung = nd.TenNguoiDung;               
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    Session["TenNguoiDung"] = nd.TenNguoiDung; 
                    return RedirectToAction("Index", "HomeAD");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản đang bị khóa");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không đúng");
                }
            }
            return View("Index");
        }
    }
}