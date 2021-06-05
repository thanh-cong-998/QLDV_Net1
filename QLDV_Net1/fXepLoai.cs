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
    public partial class fXepLoai : Form
    {
        private XepLoai_BLL stdBLL2 = new XepLoai_BLL();
        public fXepLoai()
        {
            InitializeComponent();
        }

        private void btnThemXL_Click(object sender, EventArgs e)
        {
            dataXepLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataXepLoai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            int stdXL = Convert.ToInt32(txtID.Text);

            //insert
            var std = new XepLoai();
            std.NamHoc = txtNamHoc.Text;
            std.NhanXet = richXepLoai.Text;
            std.XepLoaiDoanVien = txtXepLoai.Text;
            std.MaHoatDong = int.Parse(textBox2.Text);
            std.MaDoanVien = int.Parse(textBox1.Text);
            stdBLL2.Create(std);
            dataXepLoai.DataSource = stdBLL2.GetALL();
        }
        public void loadgiaodien()
        {
            if (CheckLogin.Quyen1.Equals("nguoidung"))
            {
                btnThemXL.Visible = false;
                btnSuaXL.Visible = false;
                btnXoaXL.Visible = false;
                btnThoatXL.Visible = false;
            }
        }
        private void fXepLoai_Load(object sender, EventArgs e)
        {
            loadgiaodien();
            dataXepLoai.DataSource = stdBLL2.GetALL();
        }

        private void btnSuaXL_Click(object sender, EventArgs e)
        {
            dataXepLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataXepLoai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            int stdXL = Convert.ToInt32(txtID.Text);
            if (stdBLL2.CheckXepLoai(stdXL))
            {
                string strNamHoc = txtNamHoc.Text;
                string strNhanXet = richXepLoai.Text;
                string strXepLoai = txtXepLoai.Text;
                stdBLL2.Edit(stdXL, strNamHoc, strNhanXet, strXepLoai, int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            }
            dataXepLoai.DataSource = stdBLL2.GetALL();
        }

        private void btnXoaXL_Click(object sender, EventArgs e)
        {
            dataXepLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataXepLoai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            try
            {
                int stdXL = Convert.ToInt32(txtID.Text);
                if (stdBLL2.CheckXepLoai(stdXL))
                {
                    stdBLL2.Delete(stdXL);
                }
                else
                {
                    MessageBox.Show("Không tồn tại !");
                }
                dataXepLoai.DataSource = stdBLL2.GetALL();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập vào ");
            }
        }

        private void btnThoatXL_Click(object sender, EventArgs e)
        {
            DialogResult mess = MessageBox.Show("Bạn chắc chắn muốn thoát hệ thống ?", "Thông báo", MessageBoxButtons.YesNo);
            if (mess == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtXepLoai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
