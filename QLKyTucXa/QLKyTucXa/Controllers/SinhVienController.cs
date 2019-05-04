using Model.DAL;
using Model.EF;
using QLKyTucXa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLKyTucXa.Controllers
{
    public class SinhVienController : Controller
    {
        protected void SetAlert(string message, string type)
        {
            TempData["AlertMessage"] = message;
            if(type=="success")
            {
                TempData["AlertType"] = "alert-success";
            }
            else if(type=="warning")
            {
                TempData["AlertType"] = "alert-warning";
            }
            else if(type=="error")
            {
                TempData["AlertType"] = "alert-danger";
            }
        }
       
        // GET: SinhVien/Create
        public ActionResult DangKy()
        {
            return View();
        }

        // POST: SinhVien/DangKy
        [HttpPost]
        public ActionResult DangKy(DangKyModel model)
        {
            if(ModelState.IsValid)
            {
                var dal = new SinhVienDAL();
                if(dal.KTSVMoi(model.IDSinhVien))
                {
                    return RedirectToAction("DangKySVCu", "SinhVien");

                }
                else
                {
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
                    sv.IDUuTien = model.IDUutien;
                    sv.NgaySinh = model.NgaySinh;
                    sv.SDT = model.SDT;
                    sv.QuocTich = model.Nationality;

                    var result = dal.ThemSV(sv);

                    var svdk = new PHIEUDANGKI();

                    svdk.IDDotDangKy = model.IDDotDangKy;
                    svdk.IDSinhVien = model.IDSinhVien;
                    svdk.NgayDangKy = DateTime.Now;
                    svdk.NV1 = model.NV1;
                    svdk.NV2 = model.NV2;
                    svdk.NV3 = model.NV3;
                    var result2 = dal.ThemSVDK(svdk);

                    if (result != null && result2 != null)
                    {
                        SetAlert("Đăng ký thành công", "success");
                        model = new DangKyModel();
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng ký không thành công");
                    }
                }
               
               
            }
            return View(model);
        }


        public ActionResult DangKySVCu()
        {
            return View();
        }

        // POST: SinhVien/DangKy
        [HttpPost]
        public ActionResult DangKySVCu(DangKyModel model)
        {
            if (ModelState.IsValid)
            {
                var dal = new SinhVienDAL();
                if (dal.KTSVMoi(model.IDSinhVien))
                {                   
                        if (dal.KTMaSV(model.IDSinhVien))
                        {
                            var svdk = new PHIEUDANGKI();

                            svdk.IDDotDangKy = model.IDDotDangKy;
                            svdk.IDSinhVien = model.IDSinhVien;
                            svdk.NgayDangKy = DateTime.Now;
                            svdk.NV1 = model.NV1;
                            svdk.NV2 = model.NV2;
                            svdk.NV3 = model.NV3;
                            var result = dal.ThemSVDK(svdk);
                            if (result != null)
                            {
                                SetAlert("Đăng ký thành công", "success");
                                model = new DangKyModel();
                                return RedirectToAction("Index", "Home");
                            }
                            else
                            {
                                ModelState.AddModelError("", "Đăng ký không thành công");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("", "Bạn không có quyền đăng ký");
                        }
                    

                }
                else
                {
                    return RedirectToAction("DangKy", "SinhVien");
                }


            }
            return View(model);
        }
        // GET: SinhVien/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SinhVien/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SinhVien/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SinhVien/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
