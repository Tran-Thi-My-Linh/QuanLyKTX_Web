using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class DotDangKyDAL
    {
        QLKyTucXaDbContext db = null;
        public DotDangKyDAL()
        {
            db = new QLKyTucXaDbContext();
        }
         public int GetIDDotDangKy()
        {           
            var ddk = db.DOTDANGKIs.Where(t => t.TrangThaiDDK == "Đang hoạt động").FirstOrDefault();
            if (ddk != null)
            {
                int id = int.Parse(ddk.IDDotDangKi.ToString());
                return id;
            }
            return -1;
        }
    }
}
