using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDV_Net1.DAL
{
    [Table("HoatDongs")]
    public class HoatDong
    {
        [Key]
        public int MaHoatDong { get; set; }
        public string TenHoatDong { get; set; }
        public string ThoiGianToChuc { get; set; }
        public string GhiChu { get; set; }
        public virtual List<XepLoai> XepLoais { get; set; }
        public virtual List<DiemDanh> DiemDanhs { get; set; }
    }
}
