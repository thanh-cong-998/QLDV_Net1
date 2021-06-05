using QLDV_Net1.BLL;
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
    public partial class fLogin : Form
    {
        private Accout_BLL _accout_BLL = new Accout_BLL();
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult mess = MessageBox.Show("Bạn chắc chắn muốn thoát hệ thống ?", "Thông báo", MessageBoxButtons.YesNo);
            if (mess == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {


            if(_accout_BLL.Check_Login(txtDangNhap.Text,txtMatKhau.Text))
            {
                if (txtDangNhap.Text.Contains("admin"))
                    CheckLogin.Quyen1 = "admin";
                else
                    CheckLogin.Quyen1 = "nguoidung";
                this.Hide();
                fHeThong f2 = new fHeThong();
                f2.Show();
            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau");

        }

        private void txtDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
