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
    public partial class fTimKiem : Form
    {
        private DoanVien_BLL doanVien_BLL = new DoanVien_BLL();
        public fTimKiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string directory = Path.GetDirectoryName(Application.ExecutablePath).Replace(@"bin\Debug", @"Picture\");
                var list = doanVien_BLL.GetById(int.Parse(textBox1.Text));

                if (list.Count > 0)
                {
                    foreach (var item in list)
                    {
                        if (item.Picture != null)
                        {
                            pictureBox1.Image = Image.FromFile("" + directory + "" + item.Picture + "");
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        dataGridView1.DataSource = list;
                    }

                }
                else
                    MessageBox.Show(" Không có thông tin mã cần tìm!");

            }
            catch (Exception)
            {
                MessageBox.Show("Xin vui lòng nhập đúng mã hoặc Không có thông tin mã cần tìm!");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
