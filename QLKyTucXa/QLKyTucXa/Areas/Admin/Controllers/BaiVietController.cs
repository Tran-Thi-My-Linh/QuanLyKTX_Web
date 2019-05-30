using Model.DAL;
using Model.EF;
using QLKyTucXa.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace QLKyTucXa.Areas.Admin.Controllers
{
    public class BaiVietController : BaseController
    {
        
        public ActionResult Index(int page=1, int pageSize=5)
        {
            var dal = new BaiVietDAL();
            var model = dal.LayDanhSachBV(page,pageSize);
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create(BAIVIET model)
        {
            if (ModelState.IsValid)
            {
                var dal = new BaiVietDAL();
                var baiviet = new BAIVIET();
                baiviet.TieuDe = model.TieuDe;
                baiviet.NoiDung = model.NoiDung;
                baiviet.HinhAnh = model.HinhAnh;
                baiviet.NgayTao = DateTime.Now;
                var result = dal.Insert(baiviet);
                if (result > 0)
                {
                    MsgBox("Thêm bài viết thành công");
                    
                }
                else
                {
                    MsgBox("Thêm bài viết thất bại");
                }
               // return RedirectToAction("Index", "BaiViet");
            }

            return View();
        }

        public ActionResult Edit(int id)
        {
            var baiviet = new BaiVietDAL().Detail(id);
            return View(baiviet);
        }

        [HttpPost]
        public ActionResult Edit(BAIVIET bv)
        {
            if (ModelState.IsValid)
            {
                var dal = new BaiVietDAL();
                var result = dal.Edit(bv);
                if (result)
                {
                    return RedirectToAction("Index", "BaiViet");
                }
                else
                {
                    MsgBox("Cập nhật bài viết thất bại");
                }
            }
            return View("Index");
        }

        public ActionResult Delete(int id)
        {
            var dal = new BaiVietDAL();
            
            BAIVIET baiviet = dal.Detail(id);
            if (baiviet == null)
            {
                return HttpNotFound();
            }
            return View(baiviet);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var dal = new BaiVietDAL();
            dal.Delete(id);
            return RedirectToAction("Index");
        }

        private void MsgBox(string sMessage)
        {
            string msg = "<script language=\"javascript\">";
            msg += "alert('" + sMessage + "');";
            msg += "</script>";
            Response.Write(msg);
        }
    }
}