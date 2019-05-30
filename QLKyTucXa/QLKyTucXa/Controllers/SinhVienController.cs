using Model.DAL;
using Model.EF;
using QLKyTucXa.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using Image = System.Drawing.Image;

namespace QLKyTucXa.Controllers
{
    public class SinhVienController : Controller
    {
        private QLKyTucXaDbContext db = new QLKyTucXaDbContext();
        int _idDDK;
        protected void SetAlert(string message, string type)
        {
            TempData["AlertMessage"] = message;
            if (type == "success")
            {
                TempData["AlertType"] = "alert-success";
            }
            else if (type == "warning")
            {
                TempData["AlertType"] = "alert-warning";
            }
            else if (type == "error")
            {
                TempData["AlertType"] = "alert-danger";
            }
        }
        public byte[] ConverterImage(string filePath)
        {
            var bitmap = new System.Drawing.Bitmap(filePath);
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(bitmap, typeof(byte[]));
            return xByte;
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public async Task<ActionResult> RenderImage(int id)
        {
            SINHVIEN item = await db.SINHVIENs.FindAsync(id);

            byte[] photoBack = item.HinhDaiDien;

            return File(photoBack, "image/png");
        }
        // GET: SinhVien/Create
        [HttpGet]
        public ActionResult DangKy()
        {
            ViewBag.NV1 = new SelectList(db.NGUYENVONGs, "IDNguyenVong", "TenNguyenVong");
            ViewBag.NV2 = new SelectList(db.NGUYENVONGs, "IDNguyenVong", "TenNguyenVong");
            ViewBag.NV3 = new SelectList(db.NGUYENVONGs, "IDNguyenVong", "TenNguyenVong");
            ViewBag.IDLop = new SelectList(db.LOPs, "IDLop", "TenLop");
            ViewBag.IDDotDangKy = new SelectList(db.DOTDANGKIs, "IDDotDangKy", "TenDotDangKy");
            ViewBag.IDUuTien = new SelectList(db.UUTIENs, "IDUuTien", "TenUuTien");
            return View();
        }

        private void MsgBox(string sMessage)
        {
            string msg = "<script language=\"javascript\">";
            msg += "alert('" + sMessage + "');";
            msg += "</script>";
            Response.Write(msg);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult DangKy(DangKyModel model, HttpPostedFileBase File1)
        {

            var dal = new SinhVienDAL();
            if (dal.KTSVMoi(model.IDSinhVien) == true)
            {
                MsgBox("Bạn đã có tài khoản. Đăng nhập để tiếp tục đăng ký ");
            }
            else
            {
                _idDDK = GetIDDotDangKy();
                if (File1 != null && File1.ContentLength > 0)
                {
                    model.HinhDaiDien = new byte[File1.ContentLength];
                    File1.InputStream.Read(model.HinhDaiDien, 0, File1.ContentLength);
                    var sv = new SINHVIEN();
                    sv.IDSinhVien = model.IDSinhVien;
                    sv.HinhDaiDien = model.HinhDaiDien;
                    sv.TenSV = model.TenSV;
                    sv.Email = model.Email;
                    sv.DanToc = model.DanToc;
                    sv.QueQuan = model.QueQuan;
                    sv.GioiTinh = model.GioiTinh;
                    sv.IDLop = model.IDLop;
                    sv.GioiTinh = model.GioiTinh;
                    sv.IDUuTien = model.IDUuTien;
                    sv.NgaySinh = model.NgaySinh;
                    sv.SDT = model.SDT;
                    sv.QuocTich = model.QuocTich;
                    sv.MatKhau = "12345678";
                    sv.NV1 = model.NV1;
                    sv.NV2 = model.NV2;
                    sv.NV3 = model.NV3;
                    var result = dal.ThemSV(sv);

                    var svdk = new PHIEUDANGKI();

                    svdk.IDDotDangKy = _idDDK;
                    svdk.IDSinhVien = model.IDSinhVien;
                    svdk.NgayDangKy = DateTime.Now;                   
                    svdk.TrangThaiPDK = "Chờ duyệt";
                    var result2 = dal.ThemSVDK(svdk);

                    if (result != null && result2 != null)
                    {
                        //SetAlert("Đăng ký thành công", "success");
                        MsgBox("Đăng ký thành công");
                        model = new DangKyModel();
                    }
                    else
                    {
                        MsgBox("Đăng ký không thành công");
                    }

                }

            }


            ViewBag.NV1 = new SelectList(db.NGUYENVONGs, "IDNguyenVong", "TenNguyenVong", model.NV1);
            ViewBag.NV2 = new SelectList(db.NGUYENVONGs, "IDNguyenVong", "TenNguyenVong", model.NV2);
            ViewBag.NV3 = new SelectList(db.NGUYENVONGs, "IDNguyenVong", "TenNguyenVong", model.NV3);
            ViewBag.IDUuTien = new SelectList(db.UUTIENs, "IDUuTien", "TenUuTien", model.IDUuTien);
            ViewBag.IDLop = new SelectList(db.LOPs, "IDLop", "TenLop", model.IDLop);
            ViewBag.IDDotDangKy = new SelectList(db.DOTDANGKIs, "IDDotDangKy", "TenDotDangKy", model.IDDotDangKy);
            return View(model);
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
        public int GetIDDotDangKy()
        {
            var dal = new DotDangKyDAL();
            int id = dal.GetIDDotDangKy();
            return id;
        }

        public ActionResult TraCuu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TraCuu(SINHVIEN sv)
        {
            if (ModelState.IsValid)
            {
                var dal = new SinhVienDAL();
                var result = dal.TimKiem(sv.IDSinhVien);
                if (result != null)
                {
                    return RedirectToAction("Detail", "SinhVien", new { id = sv.IDSinhVien });
                }
                else
                {
                    SetAlert("Sinh viên không tồn tại", "error");
                }
            }

            return View("TraCuu");

        }

               
        public ActionResult Detail(string id)
        {
            var dal = new SinhVienDAL();
            var sinhvien = dal.TimKiem(id);

            return View(sinhvien);
        }


    }
}
