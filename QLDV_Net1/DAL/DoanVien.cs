using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDV_Net1.DAL
{
    [Table("DoanViens")]
    public class DoanVien
    {
        [Key]
        public int MaDoanVien { get; set; }
        [Required(ErrorMessage = "Tên đoàn viên không được để trống")]
        public string TenDoanVien { get; set; }
        public string NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string GioiTinh { get; set; }
        public string NgayVaoDoan { get; set; }
        public int MaChiDoan { get; set; }
        public string Picture { get; set; }


        public virtual List<ChiDoan> ChiDoans { get; set; }
        public virtual List<KhenThuong> KhenThuongs { get; set; }
        public virtual List<XepLoai> XepLoais { get; set; }
        public virtual List<DiemDanh> DiemDanhs { get; set; }
    }
}
