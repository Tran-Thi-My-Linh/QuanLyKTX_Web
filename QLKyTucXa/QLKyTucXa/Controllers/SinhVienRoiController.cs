using Model.DAL;
using Model.EF;
using QLKyTucXa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKyTucXa.Controllers
{
    public class SinhVienRoiController : KiemTraDNController
    {
        // GET: SinhVienRoi
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult XinRoi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult XinRoi(SinhVienRoiModel model)
        {
            var dal = new SinhVienDAL();
            int idPLT = dal.CheckIDSinhVienInPhieuLuuTru(model.IDSinhVien);
            if(idPLT>0)
            {
                var svRoi = new PHIEUXINROI();
                svRoi.IDPhieuLuuTru = idPLT;
                svRoi.LyDoRoi = model.LyDoRoi;
                svRoi.NgayXinRoi = DateTime.Now;
                svRoi.TrangThai = false;
                var result = dal.ThemSinhVienRoi(svRoi);
                if(result>0)
                {
                    MsgBox("Nộp đơn xin rời thành công");
                    model = new SinhVienRoiModel();
                }
                else
                {
                    MsgBox("Nộp đơn xin rời thất bại");
                }
            }
            else
            {
                MsgBox("Bạn đã rời Ký Túc Xá");
            }
            return View();
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