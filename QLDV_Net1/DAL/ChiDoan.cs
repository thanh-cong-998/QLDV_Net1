using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDV_Net1.DAL
{
    [Table("ChiDoans")]
    public class ChiDoan
    {
        [Key]
        public int MaChiDoan { get; set; }
        public string TenChiDoan { get; set; }
        public virtual List<DoanVien> DoanViens { get; set; }
    }
}
