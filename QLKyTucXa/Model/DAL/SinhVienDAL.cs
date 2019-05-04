using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class SinhVienDAL:ConnectDB.ConnectDatabase
    {
        public SinhVienDAL() { }

        public bool KTSV(string masv, int ddk)
        {
            return db.PHIEUDANGKIs.Count(x => x.IDSinhVien == masv && x.IDDotDangKy==ddk) > 0;
        }
        public bool KTSVMoi(string masv)
        {
            return db.SINHVIENs.Count(x => x.IDSinhVien == masv ) > 0;
        }
        public bool KTMaSV(string masv)
        {
            var sv= db.SINHVIENs.Find( masv);
            if(sv !=null)
            {
                if( String.Equals(sv.TrangThaiSV, "Bị cấm"))
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public string ThemSV(SINHVIEN sv)
        {
            db.SINHVIENs.Add(sv);
            db.SaveChanges();
            return sv.IDSinhVien;
        }

        public string ThemSVDK(PHIEUDANGKI svdk)
        {
            db.PHIEUDANGKIs.Add(svdk);
            db.SaveChanges();
            return svdk.IDSinhVien;
        }
    }
}
