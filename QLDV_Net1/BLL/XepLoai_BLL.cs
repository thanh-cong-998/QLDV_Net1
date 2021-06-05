using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDV_Net1.DAL;

namespace QLDV_Net1.BLL
{
    class XepLoai_BLL
    {
        NetDbContext xl = new NetDbContext();
        public List<XepLoai> GetALL()
        {
            return xl.XepLoai.ToList();
        }
        public List<XepLoai> GetById(int idxeploai)
        {
            return xl.XepLoai.Where(m => m.IDXepLoai == idxeploai).ToList();
        }
        public void Create()
        {
            XepLoai std = new XepLoai();
            xl.XepLoai.Add(std);
            xl.SaveChanges();
        }
        public void Create(XepLoai std)
        {
            xl.XepLoai.Add(std);
            xl.SaveChanges();
        }
        public bool CheckXepLoai(int idxeploai)
        {
            var checkStd = xl.XepLoai.Where(m => m.IDXepLoai == idxeploai).Count();
            if (checkStd > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Edit(int idxeploai, string namhoc, string nhanxet, string xeploaidoanvien, int mdv, int mhd)
        {
            var XL = xl.XepLoai.Find(idxeploai);
            XL.NamHoc = namhoc;
            XL.NhanXet = nhanxet;
            XL.XepLoaiDoanVien = xeploaidoanvien;
            XL.MaDoanVien = mdv;
            XL.MaHoatDong = mhd;
            xl.SaveChanges();
        }
        public void Delete(int idxeploai)
        {
            var std = xl.XepLoai.Find(idxeploai);
            xl.XepLoai.Remove(std);
            xl.SaveChanges();
        }
    }
}
