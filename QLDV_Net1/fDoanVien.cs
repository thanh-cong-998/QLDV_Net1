using QLDV_Net1.BLL;
using QLDV_Net1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDV_Net1
{
    public partial class fDoanVien : Form
    {
        private DoanVien_BLL stdBLL1 = new DoanVien_BLL();
        private string namefile = "";
        public fDoanVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void loadgiaodien()
        {
            if (CheckLogin.Quyen1.Equals("nguoidung"))
            {
                btnThemDV.Visible = false;
                btnSuaDV.Visible = false;
                btnXoaDoanVien.Visible = false;
                btnThoatDV.Visible = false;
            }
        }
        private void fDoanVien_Load(object sender, EventArgs e)
        {
            loadgiaodien();
            // TODO: This line of code loads data into the 'qLDOANVIENDataSet1.ChiDoans' table. You can move, or remove it, as needed.
            this.chiDoansTableAdapter.Fill(this.qLDOANVIENDataSet1.ChiDoans);
            dataDoanVien.DataSource = stdBLL1.GetALL();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            dataDoanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDoanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            int stdDV = Convert.ToInt32(txtMaDV.Text);
            if (stdBLL1.CheckDoanVien(stdDV))
            {
                //edit or update
                string strTenDoanVien = txtTenDV.Text;
                string strNgaySinh = txtNgaySinh.Text;
                string strQueQuan = txtQueQuan.Text;
                string strGioiTinh = txtGioiTinh.Text;
                string strNgayVaoDoan = txtNgayVaoDoan.Text;
                stdBLL1.Edit(stdDV, strTenDoanVien, strNgaySinh, strQueQuan, strGioiTinh, strNgayVaoDoan);
            }
            else
            {
                if (namefile.Length > 0)
                {
                    var dv = new DoanVien();
                    dv.TenDoanVien = txtTenDV.Text;
                    dv.NgaySinh = txtNgaySinh.Text;
                    dv.QueQuan = txtQueQuan.Text;
                    dv.GioiTinh = txtGioiTinh.Text;
                    dv.NgayVaoDoan = txtNgayVaoDoan.Text;
                    dv.MaChiDoan =Convert.ToInt32(comboBox_machidoan.SelectedValue.ToString());
                    dv.Picture = namefile;
                    stdBLL1.Create(dv);
                }
                else
                {
                    MessageBox.Show("Xin vui lòng chọn ảnh !");
                }
                //insert

                //try
                //{
                //    dv.MaChiDoan = int.Parse(comboBox1.SelectedItem.ToString());
                //}
                //catch (Exception)
                //{
                //    foreach (var item in comboBox1.SelectedItem.ToString())
                //    {
                //        MessageBox.Show(item.ToString());
                //    }

                //}


            }
            dataDoanVien.DataSource = stdBLL1.GetALL();
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            dataDoanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDoanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            int stdDV = Convert.ToInt32(txtMaDV.Text);
            if (stdBLL1.CheckDoanVien(stdDV))
            {
                string strTenDoanVien = txtTenDV.Text;
                string strNgaySinh = txtNgaySinh.Text;
                string strQueQuan = txtQueQuan.Text;
                string strGioiTinh = txtGioiTinh.Text;
                string strNgayVaoDoan = txtNgayVaoDoan.Text;
                stdBLL1.Edit(stdDV, strTenDoanVien, strNgaySinh, strQueQuan, strGioiTinh, strNgayVaoDoan);
            }
            dataDoanVien.DataSource = stdBLL1.GetALL();
        }

        private void btnXoaDoanVien_Click(object sender, EventArgs e)
        {
            dataDoanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataDoanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //xoa theo ID
            try
            {
                int stdDV = Convert.ToInt32(txtMaDV.Text);
                if (stdBLL1.CheckDoanVien(stdDV))
                {
                    stdBLL1.Delete(stdDV);
                }
                else
                {
                    MessageBox.Show("Không tồn tại !");
                }
                dataDoanVien.DataSource = stdBLL1.GetALL();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập vào mã chi đoàn");
            }
        }

        private void btnThoatDV_Click(object sender, EventArgs e)
        {
            DialogResult mess = MessageBox.Show("Bạn chắc chắn muốn thoát hệ thống ?", "Thông báo", MessageBoxButtons.YesNo);
            if (mess == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;
            }
            string directory = Path.GetDirectoryName(Application.ExecutablePath).Replace(@"bin\Debug", @"Picture\");

            var randomname = DateTime.Now.ToFileTime() + Path.GetExtension(ofdImages.FileName);
            if (filepath != null)
            {
                File.Copy(filepath, "" + directory + "" + randomname + "");
                namefile = randomname;
            }

            pictureBox1.Image = Image.FromFile("" + directory + "" + randomname + "");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
