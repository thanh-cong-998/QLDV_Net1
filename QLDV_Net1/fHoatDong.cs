using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDV_Net1.DAL;
using QLDV_Net1.BLL;

namespace QLDV_Net1
{
    public partial class fHoatDong : Form
    {
        private HoatDong_BLL stdBLL4 = new HoatDong_BLL();
        public fHoatDong()
        {
            InitializeComponent();
        }

        private void btnThemHĐ_Click(object sender, EventArgs e)
        {
            dataHoatDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataHoatDong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            int stdHD = Convert.ToInt32(txtMaHD.Text);
            if (stdBLL4.CheckHoatDong(stdHD))
            {
                //edit or update
                string strTenHoatDong = txtTenHD.Text;
                string strThoiGianToChuc = txtThoiGianToChuc.Text;
                string strGhiChuHD = richGhiChu.Text;
                stdBLL4.Edit(stdHD, strTenHoatDong,strThoiGianToChuc,strGhiChuHD);
            }
            else
            {
                //insert
                var std = new HoatDong();
                std.TenHoatDong = txtTenHD.Text;
                std.ThoiGianToChuc = txtThoiGianToChuc.Text;
                std.GhiChu = richGhiChu.Text;
                stdBLL4.Create(std);
            }
            dataHoatDong.DataSource = stdBLL4.GetALL();
        }
        public void loadgiaodien()
        {
            if (CheckLogin.Quyen1.Equals("nguoidung"))
            {
                btnThemHĐ.Visible = false;
                btnSuaHD.Visible = false;
                btnXoaHD.Visible = false;
                btnThoatHD.Visible = false;
            }
        }
        private void fHoatDong_Load(object sender, EventArgs e)
        {
            loadgiaodien();
            dataHoatDong.DataSource = stdBLL4.GetALL();
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            dataHoatDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataHoatDong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            int stdHD = Convert.ToInt32(txtMaHD.Text);
            if (stdBLL4.CheckHoatDong(stdHD))
            {
                string strTenHoatDong = txtTenHD.Text;
                string strThoiGianToChuc = txtThoiGianToChuc.Text;
                string strGhiChuHD = richGhiChu.Text;
                stdBLL4.Edit(stdHD, strTenHoatDong, strThoiGianToChuc, strGhiChuHD);
            }
            dataHoatDong.DataSource = stdBLL4.GetALL();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            dataHoatDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataHoatDong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            try
            {
                int stdHD = Convert.ToInt32(txtMaHD.Text);
                if (stdBLL4.CheckHoatDong(stdHD))
                {
                    stdBLL4.Delete(stdHD);
                }
                else
                {
                    MessageBox.Show("Không tồn tại !");
                }
                dataHoatDong.DataSource = stdBLL4.GetALL();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập vào ");
            }
        }

        private void btnThoatHD_Click(object sender, EventArgs e)
        {
            DialogResult mess = MessageBox.Show("Bạn chắc chắn muốn thoát hệ thống ?", "Thông báo", MessageBoxButtons.YesNo);
            if (mess == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataHoatDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
