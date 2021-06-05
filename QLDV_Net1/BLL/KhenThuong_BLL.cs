using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDV_Net1.DAL;

namespace QLDV_Net1.BLL
{
    class KhenThuong_BLL
    {
        NetDbContext kt = new NetDbContext();
        public List<KhenThuong> GetALL()
        {
            return kt.KhenThuong.ToList();
        }
        public List<KhenThuong> GetById(int makhenthuong)
        {
            return kt.KhenThuong.Where(m => m.MaKhenThuong == makhenthuong).ToList();
        }
        public void Create()
        {
            KhenThuong std = new KhenThuong();
            kt.KhenThuong.Add(std);
            kt.SaveChanges();
        }
        public void Create(KhenThuong std)
        {
            kt.KhenThuong.Add(std);
            kt.SaveChanges();
        }
        public bool CheckKhenThuong(int makhenthuong)
        {
            var checkStd = kt.KhenThuong.Where(m => m.MaKhenThuong == makhenthuong).Count();
            if (checkStd > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //sua 
        public void Edit(int makhenthuong, string tenkhenthuong, string thanhtich, string namhoc, int mdv)
        {
            var KT = kt.KhenThuong.Find(makhenthuong);
            KT.TenKhenThuong = tenkhenthuong;
            KT.ThanhTich = thanhtich;
            KT.NamHoc = namhoc;
            KT.MaDoanVien = mdv;           
            kt.SaveChanges();
        }
        //xoa 
        public void Delete(int makhenthuong)
        {
            var std = kt.KhenThuong.Find(makhenthuong);
            kt.KhenThuong.Remove(std);
            kt.SaveChanges();
        }
    }
}
