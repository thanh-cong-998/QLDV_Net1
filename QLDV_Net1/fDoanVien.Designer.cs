
namespace QLDV_Net1
{
    partial class fDoanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDoanVien));
            this.dataDoanVien = new System.Windows.Forms.DataGridView();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnXoaDoanVien = new System.Windows.Forms.Button();
            this.btnThoatDV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtNgayVaoDoan = new System.Windows.Forms.TextBox();
            this.comboBox_machidoan = new System.Windows.Forms.ComboBox();
            this.chiDoansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDOANVIENDataSet1 = new QLDV_Net1.QLDOANVIENDataSet1();
            this.label7 = new System.Windows.Forms.Label();
            this.chiDoansTableAdapter = new QLDV_Net1.QLDOANVIENDataSet1TableAdapters.ChiDoansTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiDoansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDOANVIENDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDoanVien
            // 
            this.dataDoanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoanVien.Location = new System.Drawing.Point(-1, 443);
            this.dataDoanVien.Name = "dataDoanVien";
            this.dataDoanVien.RowHeadersWidth = 51;
            this.dataDoanVien.RowTemplate.Height = 24;
            this.dataDoanVien.Size = new System.Drawing.Size(1143, 182);
            this.dataDoanVien.TabIndex = 0;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDV.Image")));
            this.btnThemDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDV.Location = new System.Drawing.Point(12, 377);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(122, 45);
            this.btnThemDV.TabIndex = 1;
            this.btnThemDV.Text = "Thêm Mới";
            this.btnThemDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDV.Image")));
            this.btnSuaDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDV.Location = new System.Drawing.Point(222, 377);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(113, 45);
            this.btnSuaDV.TabIndex = 2;
            this.btnSuaDV.Text = "Chỉnh Sửa";
            this.btnSuaDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDV.UseVisualStyleBackColor = true;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnXoaDoanVien
            // 
            this.btnXoaDoanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDoanVien.Image")));
            this.btnXoaDoanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDoanVien.Location = new System.Drawing.Point(471, 377);
            this.btnXoaDoanVien.Name = "btnXoaDoanVien";
            this.btnXoaDoanVien.Size = new System.Drawing.Size(119, 45);
            this.btnXoaDoanVien.TabIndex = 3;
            this.btnXoaDoanVien.Text = "     Xóa";
            this.btnXoaDoanVien.UseVisualStyleBackColor = true;
            this.btnXoaDoanVien.Click += new System.EventHandler(this.btnXoaDoanVien_Click);
            // 
            // btnThoatDV
            // 
            this.btnThoatDV.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatDV.Image")));
            this.btnThoatDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatDV.Location = new System.Drawing.Point(727, 377);
            this.btnThoatDV.Name = "btnThoatDV";
            this.btnThoatDV.Size = new System.Drawing.Size(121, 45);
            this.btnThoatDV.TabIndex = 4;
            this.btnThoatDV.Text = "     Thoát ";
            this.btnThoatDV.UseVisualStyleBackColor = true;
            this.btnThoatDV.Click += new System.EventHandler(this.btnThoatDV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Đoàn Viên* :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Đoàn Viên* :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quê Quán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày Vào Đoàn";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(166, 78);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(235, 27);
            this.txtMaDV.TabIndex = 11;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(166, 142);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(235, 27);
            this.txtTenDV.TabIndex = 12;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(166, 205);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(235, 27);
            this.txtNgaySinh.TabIndex = 13;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(540, 78);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(245, 27);
            this.txtQueQuan.TabIndex = 14;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(540, 142);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(245, 27);
            this.txtGioiTinh.TabIndex = 15;
            // 
            // txtNgayVaoDoan
            // 
            this.txtNgayVaoDoan.Location = new System.Drawing.Point(540, 205);
            this.txtNgayVaoDoan.Name = "txtNgayVaoDoan";
            this.txtNgayVaoDoan.Size = new System.Drawing.Size(245, 27);
            this.txtNgayVaoDoan.TabIndex = 16;
            // 
            // comboBox_machidoan
            // 
            this.comboBox_machidoan.DataSource = this.chiDoansBindingSource;
            this.comboBox_machidoan.DisplayMember = "TenChiDoan";
            this.comboBox_machidoan.FormattingEnabled = true;
            this.comboBox_machidoan.Location = new System.Drawing.Point(166, 279);
            this.comboBox_machidoan.Name = "comboBox_machidoan";
            this.comboBox_machidoan.Size = new System.Drawing.Size(235, 27);
            this.comboBox_machidoan.TabIndex = 17;
            this.comboBox_machidoan.ValueMember = "MaChiDoan";
            this.comboBox_machidoan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chiDoansBindingSource
            // 
            this.chiDoansBindingSource.DataMember = "ChiDoans";
            this.chiDoansBindingSource.DataSource = this.qLDOANVIENDataSet1;
            // 
            // qLDOANVIENDataSet1
            // 
            this.qLDOANVIENDataSet1.DataSetName = "QLDOANVIENDataSet1";
            this.qLDOANVIENDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tên Đoàn Viên";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // chiDoansTableAdapter
            // 
            this.chiDoansTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(395, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 27);
            this.label8.TabIndex = 19;
            this.label8.Text = "THÔNG TIN ĐOÀN VIÊN\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(931, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "Chọn ảnh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(904, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // fDoanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1144, 619);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_machidoan);
            this.Controls.Add(this.txtNgayVaoDoan);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoatDV);
            this.Controls.Add(this.btnXoaDoanVien);
            this.Controls.Add(this.btnSuaDV);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.dataDoanVien);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fDoanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đoàn Viên";
            this.Load += new System.EventHandler(this.fDoanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiDoansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDOANVIENDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDoanVien;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button btnXoaDoanVien;
        private System.Windows.Forms.Button btnThoatDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtNgayVaoDoan;
        private System.Windows.Forms.ComboBox comboBox_machidoan;
        private System.Windows.Forms.Label label7;
        private QLDOANVIENDataSet1 qLDOANVIENDataSet1;
        private System.Windows.Forms.BindingSource chiDoansBindingSource;
        private QLDOANVIENDataSet1TableAdapters.ChiDoansTableAdapter chiDoansTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}