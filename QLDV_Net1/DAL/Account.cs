using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDV_Net1.DAL
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        public int IDAccount { get; set; }
        [Required(ErrorMessage = "User không được để trống")]
        public string User { get; set; }
        public string Password { get; set; }
    }
}
