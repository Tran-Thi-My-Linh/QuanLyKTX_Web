using Model.DAL;
using QLKyTucXa.Common;
using QLKyTucXa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKyTucXa.Controllers
{
    public class DangNhapController : Controller
    {
        // GET: DangNhap
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DangNhap(DangNhapModel model)
        {
            if (ModelState.IsValid)
            {
                var dal = new SinhVienDAL();
                //var result = dal.Login(model.IDNguoiDung, Encryptor.MD5Hash(model.MatKhau));
                var result = dal.Login(model.IDSinhVien, model.MatKhau);
                if (result == 1)
                {
                    var sinhvien = dal.GetByID(model.IDSinhVien);
                    var svSession = new SinhVienDangNhap();
                    svSession.IDSinhVien = sinhvien.IDSinhVien;
                    svSession.TenSinhVien = sinhvien.TenSV;
                    Session.Add(CommonConstants.USER_SESSION, svSession);
                    Session["TenSinhVien"] = sinhvien.TenSV;
                    return RedirectToAction("Index", "Home");
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