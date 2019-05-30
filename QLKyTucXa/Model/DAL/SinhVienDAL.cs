using Model.EF;
using Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    
    public class SinhVienDAL
    {
        QLKyTucXaDbContext db = null;

        public SinhVienDAL() {
            db = new QLKyTucXaDbContext();
        }

        public SINHVIEN GetByID(string id)
        {
            return db.SINHVIENs.SingleOrDefault(x=>x.IDSinhVien==id);
        }

        public int Login(string userName, string password)
        {
            var result = db.SINHVIENs.SingleOrDefault(x => x.IDSinhVien == userName);
            if (result == null)
            {
                // Không tồn tại
                return 0;
            }
            else
            {
                if (String.Equals(result.TrangThaiSV, "Bị đuổi"))
                {
                    // Bị cấm
                    return -1;
                }
                else
                {
                    if (result.MatKhau == password)
                    {
                        // Thành công
                        return 1;
                    }
                    else
                    {
                        // Sai mật khẩu
                        return -2;
                    }
                }
            }
        }

        public SINHVIEN TimKiem(string id)
        {
            return db.SINHVIENs.Find(id);
        }

        public List<SinhVienViewModel> XemThongTin(string id)
        {
            var model = from sv in db.SINHVIENs
                        join plt in db.PHIEULUUTRUs
                        on sv.IDSinhVien equals plt.IDSinhVien
                        where sv.IDSinhVien == id
                        select new SinhVienViewModel()
                        {
                            HinhDaiDien = sv.HinhDaiDien,
                            TenSV = sv.TenSV,
                            NgaySinh = sv.NgaySinh,
                            GioiTinh = sv.GioiTinh,
                            QueQuan = sv.QueQuan,
                            SDT = sv.SDT,
                            Email = sv.Email,
                            DanToc = sv.DanToc,
                            QuocTich = sv.QuocTich,
                            IDLop = sv.IDLop,
                            TrangThaiSV = sv.TrangThaiSV,
                            IDPhong = plt.IDPhong,
                            NgayBatDau = plt.NgayBatDau,
                            NgayKetThuc = plt.NgayKetThuc

                        };
            return model.ToList();
        }

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
                if( String.Equals(sv.TrangThaiSV, "Bị đuổi"))
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

        public bool UpdateSV(string masv,int nv1, int nv2, int nv3)
        {
            try
            {
                var sinhvien = db.SINHVIENs.Find(masv);
                sinhvien.NV1 = nv1;
                sinhvien.NV2 = nv2;
                sinhvien.NV3 = nv3;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string ThemSVDK(PHIEUDANGKI svdk)
        {
            db.PHIEUDANGKIs.Add(svdk);
            db.SaveChanges();
            return svdk.IDSinhVien;
        }

        public int CheckIDSinhVienInPhieuLuuTru(string idSV)
        {
            var sv = db.PHIEULUUTRUs.Where(t => t.IDSinhVien == idSV && t.TrangThai == true).FirstOrDefault();
            return sv != null ? sv.IDPhieuLuuTru : -1;
        }

        public int ThemSinhVienRoi(PHIEUXINROI sv)
        {
            db.PHIEUXINROIs.Add(sv);
            db.SaveChanges();
            return sv.IDPhieuXinRoi;
        }
    }
}
