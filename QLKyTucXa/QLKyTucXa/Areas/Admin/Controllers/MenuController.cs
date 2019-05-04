using Model.DAL;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKyTucXa.Areas.Admin.Controllers
{
    public class MenuController : BaseController
    {
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
        // GET: Admin/Menu
        public ActionResult Index()
        {
            var dal = new MenuDAL();
            var model = dal.LayDanhSachMN();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Menu menu)
        {
            if (ModelState.IsValid)
            {

                var dal = new MenuDAL();
                var mn = new Menu();
                mn.TenMenu = menu.TenMenu;
                mn.Link = menu.Link;
                mn.ThuTuHienThi = menu.ThuTuHienThi;
                mn.TrangThai = menu.TrangThai;
                mn.LoaiMenu = menu.LoaiMenu;
                mn.MenuCha = menu.MenuCha;
                mn.Icon = menu.Icon;
                mn.ThuocTinh = menu.ThuocTinh;
                var result = dal.Insert(mn);
                if (result > 0)
                {
                    SetAlert("Tạo menu thành công", "success");
                    return RedirectToAction("Index", "Menu");
                }
                else
                {
                    ModelState.AddModelError("", "Tạo menu không thành công");
                }
            }

            return View();
        }

        public ActionResult Edit(int id)
        {
            var menu = new MenuDAL().Detail(id);
            return View(menu);
        }

        [HttpPost]
        public ActionResult Edit(Menu mn)
        {
            if (ModelState.IsValid)
            {
                var dal = new MenuDAL();
                var result = dal.Update(mn);
                if (result)
                {
                    return RedirectToAction("Index", "Menu");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật menu thất bại");
                }
            }
            return View("Index");
        }

        public ActionResult Delete(int id)
        {
            var dal = new MenuDAL();

            Menu menu = dal.Detail(id);
            if (menu == null)
            {
                return HttpNotFound();
            }
            return View(menu);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var dal = new MenuDAL();
            dal.Delete(id);
            return RedirectToAction("Index");
        }
    }
}