using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDV_Net1.DAL;

namespace QLDV_Net1.BLL
{
    class DiemDanh_BLL
    {
        NetDbContext dd = new NetDbContext();
        public List<DiemDanh> GetALL()
        {
            return dd.DiemDanh.ToList();
        }
        public List<DiemDanh> GetById(int iddiemdanh)
        {
            return dd.DiemDanh.Where(m => m.IDDiemDanh == iddiemdanh).ToList();
        }
        public void Create()
        {
            DiemDanh std = new DiemDanh();
            dd.DiemDanh.Add(std);
            dd.SaveChanges();
        }
        public void Create(DiemDanh std)
        {
            dd.DiemDanh.Add(std);
            dd.SaveChanges();
        }
        public bool CheckDiemDanh(int iddiemdanh)
        {
            var checkStd = dd.DiemDanh.Where(m => m.IDDiemDanh == iddiemdanh).Count();
            if (checkStd > 0)
            {
                //co ton tai ChiDoan  voi MaChiDoan == machidoan
                return true;
            }
            else
            {
                return false;
            }
        }
        //sua ten theo id diem danh
        public void Edit(int iddiemdanh, string ghichu)
        {
            var DD = dd.DiemDanh.Find(iddiemdanh);
            DD.GhiChu = ghichu;
            dd.SaveChanges();
        }

        public void EditAll(DiemDanh diemDanh)
        {
            //  dbSet.Attach(entityToUpdate);
            // _context.Entry(entityToUpdate).State = EntityState.Modified;
            // dd.DiemDanh.Attach(diemDanh);
            //  dd.Entry(diemDanh).State = EntityState.Modified;
            var DD = dd.DiemDanh.Find(diemDanh.IDDiemDanh);
            DD.GhiChu = diemDanh.GhiChu;
            DD.MaDoanVien = diemDanh.MaDoanVien;
            DD.MaHoatDong = diemDanh.MaHoatDong;
            dd.SaveChanges();
        }
        //xoa theo id diem danh
        public void Delete(int iddiemdanh)
        {
            var std = dd.DiemDanh.Find(iddiemdanh);
            dd.DiemDanh.Remove(std);
            dd.SaveChanges();
        }
    }
}
