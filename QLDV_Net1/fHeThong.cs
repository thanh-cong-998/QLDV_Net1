using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDV_Net1
{
    public partial class fHeThong : Form
    {
        public fHeThong()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult mess = MessageBox.Show("Bạn muốn thoát hệ thống ?", "Thông báo", MessageBoxButtons.YesNo);
            if (mess == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void chiĐoànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChiDoan f2 = new fChiDoan();
            f2.Show();
        }

        private void đoànViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDoanVien f2 = new fDoanVien();
            f2.Show();
        }

        private void hoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHoatDong f2 = new fHoatDong();
            f2.Show();
        }

        private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDiemDanh f2 = new fDiemDanh();
            f2.Show();
        }

        private void khenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKhenThuong f2 = new fKhenThuong();
            f2.Show();
        }

        private void xếpLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXepLoai f2 = new fXepLoai();
            f2.Show();
        }

        private void fHeThong_Load(object sender, EventArgs e)
        {

        }

        private void traCứuThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTimKiem f2 = new fTimKiem();
            f2.Show();
        }
    }
}
