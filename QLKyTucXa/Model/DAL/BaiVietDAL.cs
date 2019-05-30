using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Model.DAL
{
    //public class BaiVietDAL:ConnectDB.ConnectDatabase
    public class BaiVietDAL
    {
        QLKyTucXaDbContext db = null;
        public BaiVietDAL() {
            db = new QLKyTucXaDbContext();
        }

        public int Insert(BAIVIET bv)
        {
            db.BAIVIETs.Add(bv);
            db.SaveChanges();
            return bv.IDBaiViet;
        }

        public IEnumerable<BAIVIET> LayDanhSachBV(int page, int pageSize)
        {
            return db.BAIVIETs.OrderByDescending(x=>x.NgayTao).ToPagedList(page,pageSize);
        }

        public IEnumerable<BAIVIET> DanhSachBV()
        {
            return db.BAIVIETs;
        }
        
        public bool Edit(BAIVIET bv)
        {
            try
            {
                var baiviet = db.BAIVIETs.Find(bv.IDBaiViet);
                baiviet.TieuDe = bv.TieuDe;
                baiviet.NoiDung = bv.NoiDung;
                baiviet.HinhAnh = bv.HinhAnh;
                baiviet.NgayTao = bv.NgayTao;
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }           
        }

        public bool Delete(int id)
        {
            try
            {
                var baiviet = db.BAIVIETs.Find(id);
                db.BAIVIETs.Remove(baiviet);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public BAIVIET Detail (int id)
        {
            return db.BAIVIETs.Find(id);
        }
    }
}
