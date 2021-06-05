using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDV_Net1.DAL
{
    [Table("KhenThuongs")]
    public class KhenThuong
    {
        [Key]
        public int MaKhenThuong { get; set; }
        public string TenKhenThuong { get; set; }
        public string ThanhTich { get; set; }
        public string NamHoc { get; set; }
        public int MaDoanVien { get; set; }
        public virtual List<DoanVien> DoanViens { get; set; }
    }
}
