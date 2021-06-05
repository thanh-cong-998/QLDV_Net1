using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDV_Net1.DAL;

namespace QLDV_Net1.BLL
{
    class HoatDong_BLL
    {
        NetDbContext hd = new NetDbContext();
        public List<HoatDong> GetALL()
        {
            return hd.HoatDong.ToList();
        }
        public List<HoatDong> GetById(int mahoatdong)
        {
            return hd.HoatDong.Where(m => m.MaHoatDong == mahoatdong).ToList();
        }
        public void Create()
        {
            HoatDong std = new HoatDong();
            hd.HoatDong.Add(std);
            hd.SaveChanges();
        }
        public void Create(HoatDong std)
        {
            hd.HoatDong.Add(std);
            hd.SaveChanges();
        }
        public bool CheckHoatDong(int mahoatdong)
        {
            var checkStd = hd.HoatDong.Where(m => m.MaHoatDong == mahoatdong).Count();
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
        public void Edit(int mahoatdong, string tenhoatdong,string thoigiantochuc,string ghichu)
        {
            var HD = hd.HoatDong.Find(mahoatdong);
            HD.TenHoatDong = tenhoatdong;
            HD.ThoiGianToChuc = thoigiantochuc;
            HD.GhiChu = ghichu;
            hd.SaveChanges();
        }
        //xoa 
        public void Delete(int mahoatdong)
        {
            var std = hd.HoatDong.Find(mahoatdong);
            hd.HoatDong.Remove(std);
            hd.SaveChanges();
        }
    }
}
