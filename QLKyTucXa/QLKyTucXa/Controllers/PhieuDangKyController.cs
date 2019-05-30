using Model.DAL;
using Model.EF;
using QLKyTucXa.Common;
using QLKyTucXa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKyTucXa.Controllers
{
    public class PhieuDangKyController : KiemTraDNController
    {
        private QLKyTucXaDbContext db = new QLKyTucXaDbContext();
        int _idDDK;
       
        public int GetIDDotDangKy()
        {
            var dal = new DotDangKyDAL();
            int id = dal.GetIDDotDangKy();
            return id;
        }
        // GET: PhieuDangKy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DangKy()
        {
            ViewBag.NV1 = new SelectList(db.NGUYENVONGs, "IDNguyenVong", "TenNguyenVong");
            ViewBag.NV2 = new SelectList(db.NGUYENVONGs, "IDNguyenVong", "TenNguyenVong");
            ViewBag.NV3 = new SelectList(db.NGUYENVONGs, "IDNguyenVong", "TenNguyenVong");
            ViewBag.IDDotDangKy = new SelectList(db.DOTDANGKIs, "IDDotDangKy", "TenDotDangKy");
            return View();
        }

       
        [HttpPost]
        public ActionResult DangKy(DangKyModel model)
        {
            _idDDK = GetIDDotDangKy();
            var session = (SinhVienDangNhap)Session[CommonConstants.USER_SESSION];
            var dal = new SinhVienDAL();                
            if (dal.KTSV(session.IDSinhVien,model.IDDotDangKy)==false)
             {
                
                 var svdk = new PHIEUDANGKI();                 
                 var result2 = dal.UpdateSV(session.IDSinhVien,model.NV1,model.NV2,model.NV3);
                 svdk.IDDotDangKy = _idDDK;
                 svdk.IDSinhVien = session.IDSinhVien;
                 svdk.NgayDangKy = DateTime.Now;                 
                 svdk.TrangThaiPDK = "Chờ duyệt";
                 var result = dal.ThemSVDK(svdk);
                 if (result != null && result2 == true)
                 {
                      MsgBox("Đăng ký thành công");
                      model = new DangKyModel();
                      //return RedirectToAction("Index", "Home");
                 }
                 else
                 {
                      MsgBox("Đăng ký không thành công");
                 }
            }
             else
             {
                MsgBox("Bạn đã đăng ký trong đợt này rồi");
             }

            ViewBag.NV1 = new SelectList(db.NGUYENVONGs, "IDNguyenVong", "TenNguyenVong", model.NV1);
            ViewBag.NV2 = new SelectList(db.NGUYENVONGs, "IDNguyenVong", "TenNguyenVong", model.NV2);
            ViewBag.NV3 = new SelectList(db.NGUYENVONGs, "IDNguyenVong", "TenNguyenVong", model.NV3);
            ViewBag.IDDotDangKy = new SelectList(db.DOTDANGKIs, "IDDotDangKy", "TenDotDangKy", model.IDDotDangKy);
            return View(model);
        }

        private void MsgBox(string sMessage)
        {
            string msg = "<script language=\"javascript\">";
            msg += "alert('" + sMessage + "');";
            msg += "</script>";
            Response.Write(msg);
        }

        [HttpPost]
        public JsonResult CheckDotDangKy()
        {
            var dotDangKyDAL = new DotDangKyDAL();
            _idDDK = dotDangKyDAL.GetIDDotDangKy();
            if (_idDDK > 0)
            {
                return Json(new { IsError = false, Message = "" }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { IsError = true, Message = "Hiện tại chưa có đợt đăng ký nào được mở" }, JsonRequestBehavior.AllowGet);
        }
    }
}