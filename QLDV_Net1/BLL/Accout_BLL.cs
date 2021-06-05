using QLDV_Net1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDV_Net1.BLL
{
    class Accout_BLL
    {
        private NetDbContext _db = null;
        public Accout_BLL()
        {
            _db = new NetDbContext();
        }


        public bool Check_Login(string user, string pass)
        {
            var result = _db.Account.FirstOrDefault(x => x.User.Equals(user) && x.Password.Equals(pass));
            return result == null ? false : true;
        }
    }
}
