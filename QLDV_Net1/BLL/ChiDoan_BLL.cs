using QLDV_Net1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDV_Net1.BLL
{
    class ChiDoan_BLL
    {
        NetDbContext db = new NetDbContext();
        public List<ChiDoan> GetALL()
        {
            return db.ChiDoan.ToList();
        }
        public List<ChiDoan> GetById(int machidoan)
        {
            return db.ChiDoan.Where(m => m.MaChiDoan == machidoan).ToList();
        }
        public void Create()
        {
            ChiDoan std = new ChiDoan();
            db.ChiDoan.Add(std);
            db.SaveChanges();
        }
        public void Create(ChiDoan std)
        {
            db.ChiDoan.Add(std);
            db.SaveChanges();
        }
        public bool CheckChiDoan(int machidoan)
        {
            var checkStd = db.ChiDoan.Where(m => m.MaChiDoan == machidoan).Count();
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
        //sua ten theo ma chi doan
        public void Edit(int machidoan, string tenchidoan)
        {
            var CD = db.ChiDoan.Find(machidoan);
            CD.TenChiDoan = tenchidoan;
            db.SaveChanges();
        }
        //xoa theo ma chi doan
        public void Delete(int machidoan)
        {
            var std = db.ChiDoan.Find(machidoan);
            db.ChiDoan.Remove(std);
            db.SaveChanges();
        }
    }
}
