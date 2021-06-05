 using QLDV_Net1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDV_Net1.BLL
{
    class DoanVien_BLL
    {
        NetDbContext db1 = new NetDbContext();
        public List<DoanVien> GetALL()
        {
            return db1.DoanVien.ToList();
        }
        public List<DoanVien> GetById(int madoanvien)
        {
            return db1.DoanVien.Where(m => m.MaDoanVien == madoanvien).ToList();
        }
        public DoanVien GetId(int madoanvien)
        {
            return db1.DoanVien.Where(m => m.MaDoanVien == madoanvien).SingleOrDefault();
        }

        public void Create()
        {
             DoanVien std = new DoanVien();
            db1.DoanVien.Add(std);
            db1.SaveChanges();
        }
        public void Create(DoanVien dv)
        {
            db1.DoanVien.Add(dv);
            db1.SaveChanges();
        }
        public bool CheckDoanVien(int madoanvien)
        {
            var checkdv = db1.DoanVien.Where(m => m.MaDoanVien == madoanvien).Count();
            if (checkdv > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //sua ten theo ma doan vien
        public void Edit(int madoanvien, string tendoanvien, string ngaysinh, string quequan,string gioitinh,string ngayvaodoan)
        {
            var DV = db1.DoanVien.Find(madoanvien);
            DV.TenDoanVien = tendoanvien;
            DV.NgaySinh = ngaysinh;
            DV.QueQuan = quequan;
            DV.GioiTinh = gioitinh;
            DV.NgayVaoDoan = ngayvaodoan;
            db1.SaveChanges();
        }
        //xoa theo ma doan vien
        public void Delete(int madoanvien)
        {
            var dv = db1.DoanVien.Find(madoanvien);
            db1.DoanVien.Remove(dv);
            db1.SaveChanges();
        }
    }
}
