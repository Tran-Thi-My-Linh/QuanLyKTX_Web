using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class NguoiDungDAL:ConnectDB.ConnectDatabase
    {
        
        public NguoiDungDAL()
        { }

        public string Insert(NGUOIDUNG nd)
        {
            db.NGUOIDUNGs.Add(nd);
            db.SaveChanges();
            return nd.IDNguoiDung;
        }

        public int Login(string userName, string password)
        {
            var result = db.NGUOIDUNGs.SingleOrDefault(x => x.IDNguoiDung == userName );
            if(result ==null)
            {
                // Không tồn tại
                return 0;
            }
            else
            {
                if(result.TrangThaiNguoiDung==false)
                {
                    // Bị khóa
                    return -1;
                }
                else
                {
                    if(result.MatKhau==password)
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

        public NGUOIDUNG GetByID(string id)
        {
            return db.NGUOIDUNGs.SingleOrDefault(x => x.IDNguoiDung == id);
        }
    }
}
