//using QLDV_Net1.BLL;
using QLDV_Net1.BLL;
using QLDV_Net1.DAL;
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
    public partial class fChiDoan : Form
    {
        //tao con tro stdBLL
        private ChiDoan_BLL stdBLL = new ChiDoan_BLL();
        private void fChiDoan_Load(object sender, EventArgs e)
        {
            loadgiaodien();
            dataChiDoan.DataSource = stdBLL.GetALL();
        }
        public fChiDoan()
        {
            InitializeComponent();
        }
        public void loadgiaodien()
        {
            if(CheckLogin.Quyen1.Equals("nguoidung"))
            {
                btnThemCD.Visible = false;
                btnSuaCD.Visible = false;
                btnXoaCD.Visible = false;
                btnThoatCD.Visible = false;
            }    
        }
        private void txtMaChiDoan_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnThemCD_Click(object sender, EventArgs e)
        {
            dataChiDoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataChiDoan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            int stdCD = Convert.ToInt32(txtMaChiDoan.Text);
            if (stdBLL.CheckChiDoan(stdCD))
            {
                //edit or update

                string strTenChiDoan = txtTenChiDoan.Text;
                stdBLL.Edit(stdCD, strTenChiDoan);
            }
            else
            {
                //insert
                var std = new ChiDoan();
                std.TenChiDoan = txtTenChiDoan.Text;
                stdBLL.Create(std);
            }
            dataChiDoan.DataSource = stdBLL.GetALL();
        }

        private void btnSuaCD_Click(object sender, EventArgs e)
        {
            dataChiDoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataChiDoan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            int stdCD = Convert.ToInt32(txtMaChiDoan.Text);
            if (stdBLL.CheckChiDoan(stdCD))
            {
                string strTenChiDoan = txtTenChiDoan.Text;
                stdBLL.Edit(stdCD, strTenChiDoan);
            }
            dataChiDoan.DataSource = stdBLL.GetALL();
        }

        private void dataChiDoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoaCD_Click(object sender, EventArgs e)
        {
            dataChiDoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataChiDoan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //xoa theo ID
            try
            {
                int stdCD = Convert.ToInt32(txtMaChiDoan.Text);
                if (stdBLL.CheckChiDoan(stdCD))
                {
                    stdBLL.Delete(stdCD);
                }
                else
                {
                    MessageBox.Show("Không tồn tại !");
                }
                dataChiDoan.DataSource = stdBLL.GetALL();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập vào mã chi đoàn");
            }
        }

        private void btnThoatCD_Click(object sender, EventArgs e)
        {
            DialogResult mess = MessageBox.Show("Bạn chắc chắn muốn thoát hệ thống ?", "Thông báo", MessageBoxButtons.YesNo);
            if (mess == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtTenChiDoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
