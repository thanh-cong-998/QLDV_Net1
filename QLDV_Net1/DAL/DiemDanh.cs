using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDV_Net1.DAL
{
    [Table("DiemDanhs")]
    public class DiemDanh
    {
        [Key]
        public int IDDiemDanh { get; set; }
        public string GhiChu { get; set; }
        public int MaDoanVien { get; set; }
        public int MaHoatDong { get; set; }
        public virtual List<DoanVien> DoanViens { get; set; }
        public virtual List<HoatDong> HoatDongs { get; set; }
    }
}
