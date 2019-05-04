using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class MenuDAL : ConnectDB.ConnectDatabase
    {
        public MenuDAL()
        {

        }

        public List<Menu> ListMenu()
        {
            return db.Menus.Where(t => t.TrangThai == true).ToList();
        }
        public IEnumerable<Menu> LayDanhSachMN()
        {
            return db.Menus;
        }
        public int Insert (Menu menu)
        {
            db.Menus.Add(menu);
            db.SaveChanges();
            return menu.IDMenu;
        }

        public bool Update(Menu menu)
        {
            try
            {
                var mn = db.Menus.Find(menu.IDMenu);
                mn.TenMenu = menu.TenMenu;
                mn.Link = menu.Link;
                mn.ThuTuHienThi = menu.ThuTuHienThi;
                mn.TrangThai = menu.TrangThai;
                mn.LoaiMenu = menu.LoaiMenu;
                mn.MenuCha = menu.MenuCha;
                mn.Icon = menu.Icon;
                mn.ThuocTinh = menu.ThuocTinh;
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
                var mn = db.Menus.Find(id);
                db.Menus.Remove(mn);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public Menu Detail(int id)
        {
            return db.Menus.Find(id);
        }
    }
}
