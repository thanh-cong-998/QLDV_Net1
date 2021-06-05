using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDV_Net1.BLL;
using QLDV_Net1.DAL;

namespace QLDV_Net1
{
    public partial class fDiemDanh : Form
    {
        private DiemDanh_BLL stdBLL3 = new DiemDanh_BLL();
        private DoanVien_BLL DoanVien_BLL = new DoanVien_BLL();
        public fDiemDanh()
        {
            InitializeComponent();
        }

        private void btnThemDD_Click(object sender, EventArgs e)
        {
            dataDiemDanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDiemDanh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            int stdDD = Convert.ToInt32(txtDD.Text);
            if (stdBLL3.CheckDiemDanh(stdDD))
            {
                //edit or update
                string strGhiChu = richtxtGhiChu.Text;
                int  MaHoatDong = int.Parse(textBox2.Text);
                int MaDoanVien = int.Parse(textBox1.Text);
                stdBLL3.Edit(stdDD, strGhiChu);

            }
            else
            {
                //insert
                var std = new DiemDanh();
                std.GhiChu = richtxtGhiChu.Text;
                std.MaHoatDong = int.Parse(textBox2.Text);
                std.MaDoanVien = int.Parse(textBox1.Text);
                stdBLL3.Create(std);
            }
            dataDiemDanh.DataSource = stdBLL3.GetALL();
        }
        public void loadgiaodien()
        {
            dataDiemDanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDiemDanh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            if (CheckLogin.Quyen1.Equals("nguoidung"))
            {
                btnThemDD.Visible = false;
                btnSuaDD.Visible = false;
                btnXoaDD.Visible = false;
                btnThoatDD.Visible = false;
            }
        }
        private void fDiemDanh_Load(object sender, EventArgs e)
        {
            loadgiaodien();
            dataDiemDanh.DataSource = stdBLL3.GetALL();
        }

        private void btnSuaDD_Click(object sender, EventArgs e)
        {
            int stdDD = Convert.ToInt32(txtDD.Text);
            if (stdBLL3.CheckDiemDanh(stdDD))
            {
                var std = new DiemDanh();
                std.IDDiemDanh = int.Parse(txtDD.Text);
                std.GhiChu = richtxtGhiChu.Text;
                std.MaHoatDong = int.Parse(textBox2.Text);
                std.MaDoanVien = int.Parse(textBox1.Text);
                stdBLL3.EditAll(std);
                MessageBox.Show("Chỉnh sửa thành công nha !");
            }
            dataDiemDanh.DataSource = stdBLL3.GetALL();
        }

        private void btnXoaDD_Click(object sender, EventArgs e)
        {
            dataDiemDanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDiemDanh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            try
            {
                int stdDD = Convert.ToInt32(txtDD.Text);
                if (stdBLL3.CheckDiemDanh(stdDD))
                {
                    stdBLL3.Delete(stdDD);
                }
                else
                {
                    MessageBox.Show("Không tồn tại !");
                }
                dataDiemDanh.DataSource = stdBLL3.GetALL();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập vào ");
            }
        }

        private void btnThoatDD_Click(object sender, EventArgs e)
        {
            DialogResult mess = MessageBox.Show("Bạn chắc chắn muốn thoát hệ thống ?", "Thông báo", MessageBoxButtons.YesNo);
            if (mess == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtDD_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataDiemDanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
