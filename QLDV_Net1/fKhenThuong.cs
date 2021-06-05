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
    public partial class fKhenThuong : Form
    {
        private KhenThuong_BLL stdBLL5 = new KhenThuong_BLL();
        public fKhenThuong()
        {
            InitializeComponent();
        }

        public void loadgiaodien()
        {
            if (CheckLogin.Quyen1.Equals("nguoidung"))
            {
                btnThemKT.Visible = false;
                btnSuaKT.Visible = false;
                btnXoaKT.Visible = false;
                btnThoatKT.Visible = false;
            }
        }
        private void fKhenThuong_Load(object sender, EventArgs e)
        {
            loadgiaodien();
            dataKhenThuong.DataSource = stdBLL5.GetALL();
        }

        private void btnThemKT_Click(object sender, EventArgs e)
        {
            dataKhenThuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataKhenThuong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            int stdKT = Convert.ToInt32(txtMaKT.Text);
            //insert
            var std = new KhenThuong();
            string strTenKhenThuong = txtTenKT.Text;
            string strThanhTich = richThanhTich.Text;
            string strNamHoc = txtNamHoc.Text;
            int mdv = int.Parse(textBox1.Text);
            std.MaDoanVien = mdv;
            std.TenKhenThuong = strTenKhenThuong;
            std.ThanhTich = strThanhTich;
            std.NamHoc = strNamHoc;
            stdBLL5.Create(std);
            dataKhenThuong.DataSource = stdBLL5.GetALL();
        }

        private void btnSuaKT_Click(object sender, EventArgs e)
        {
            dataKhenThuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataKhenThuong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            try
            {
                int stdKT = Convert.ToInt32(txtMaKT.Text);
                if (stdBLL5.CheckKhenThuong(stdKT))
                {
                    string strTenKhenThuong = txtTenKT.Text;
                    string strThanhTich = richThanhTich.Text;
                    string strNamHoc = txtNamHoc.Text;
                    int mdv = int.Parse(textBox1.Text);
                    stdBLL5.Edit(stdKT, strTenKhenThuong, strThanhTich, strNamHoc, mdv);
                }
                dataKhenThuong.DataSource = stdBLL5.GetALL();
            }
            catch (Exception)
            {

                MessageBox.Show("Xin bạn vui lòng thử lại nha !");
            }

        }

        private void btnXoaKT_Click(object sender, EventArgs e)
        {
            dataKhenThuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataKhenThuong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            try
            {
                int stdKT = Convert.ToInt32(txtMaKT.Text);
                if (stdBLL5.CheckKhenThuong(stdKT))
                {
                    stdBLL5.Delete(stdKT);
                }
                else
                {
                    MessageBox.Show("Không tồn tại !");
                }
                dataKhenThuong.DataSource = stdBLL5.GetALL();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập vào ");
            }
        }

        private void btnThoatKT_Click(object sender, EventArgs e)
        {
            DialogResult mess = MessageBox.Show("Bạn chắc chắn muốn thoát hệ thống ?", "Thông báo", MessageBoxButtons.YesNo);
            if (mess == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void richThanhTich_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
