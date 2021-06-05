using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDV_Net1.DAL
{
    [Table("XepLoais")]
    public class XepLoai
    {
        [Key]
        public int IDXepLoai { get; set; }
        public string NamHoc { get; set; }
        public string NhanXet { get; set; }
        public string XepLoaiDoanVien { get; set; }
        public int MaDoanVien { get; set; }
        public int MaHoatDong { get; set; }
        public virtual List<DoanVien> DoanViens { get; set; }
        public virtual List<HoatDong> HoatDongs { get; set; }
    }
}
