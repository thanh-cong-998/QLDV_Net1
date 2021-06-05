
namespace QLDV_Net1
{
    partial class fKhenThuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fKhenThuong));
            this.dataKhenThuong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKT = new System.Windows.Forms.TextBox();
            this.txtTenKT = new System.Windows.Forms.TextBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.btnThemKT = new System.Windows.Forms.Button();
            this.btnSuaKT = new System.Windows.Forms.Button();
            this.btnXoaKT = new System.Windows.Forms.Button();
            this.btnThoatKT = new System.Windows.Forms.Button();
            this.richThanhTich = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhenThuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataKhenThuong
            // 
            this.dataKhenThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKhenThuong.Location = new System.Drawing.Point(0, 366);
            this.dataKhenThuong.Name = "dataKhenThuong";
            this.dataKhenThuong.RowHeadersWidth = 51;
            this.dataKhenThuong.RowTemplate.Height = 24;
            this.dataKhenThuong.Size = new System.Drawing.Size(900, 169);
            this.dataKhenThuong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khen Thưởng* :\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khen Thưởng* :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thành Tích* :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Năm Học* :";
            // 
            // txtMaKT
            // 
            this.txtMaKT.Location = new System.Drawing.Point(180, 121);
            this.txtMaKT.Name = "txtMaKT";
            this.txtMaKT.Size = new System.Drawing.Size(164, 27);
            this.txtMaKT.TabIndex = 6;
            // 
            // txtTenKT
            // 
            this.txtTenKT.Location = new System.Drawing.Point(180, 173);
            this.txtTenKT.Name = "txtTenKT";
            this.txtTenKT.Size = new System.Drawing.Size(164, 27);
            this.txtTenKT.TabIndex = 7;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(180, 229);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(164, 27);
            this.txtNamHoc.TabIndex = 8;
            // 
            // btnThemKT
            // 
            this.btnThemKT.BackColor = System.Drawing.Color.LightGray;
            this.btnThemKT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKT.Image")));
            this.btnThemKT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKT.Location = new System.Drawing.Point(73, 310);
            this.btnThemKT.Name = "btnThemKT";
            this.btnThemKT.Size = new System.Drawing.Size(126, 41);
            this.btnThemKT.TabIndex = 9;
            this.btnThemKT.Text = "Thêm Mới\r\n";
            this.btnThemKT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemKT.UseVisualStyleBackColor = false;
            this.btnThemKT.Click += new System.EventHandler(this.btnThemKT_Click);
            // 
            // btnSuaKT
            // 
            this.btnSuaKT.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKT.Image")));
            this.btnSuaKT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaKT.Location = new System.Drawing.Point(272, 310);
            this.btnSuaKT.Name = "btnSuaKT";
            this.btnSuaKT.Size = new System.Drawing.Size(121, 41);
            this.btnSuaKT.TabIndex = 10;
            this.btnSuaKT.Text = "Chỉnh Sửa\r\n";
            this.btnSuaKT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaKT.UseVisualStyleBackColor = true;
            this.btnSuaKT.Click += new System.EventHandler(this.btnSuaKT_Click);
            // 
            // btnXoaKT
            // 
            this.btnXoaKT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKT.Image")));
            this.btnXoaKT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaKT.Location = new System.Drawing.Point(480, 310);
            this.btnXoaKT.Name = "btnXoaKT";
            this.btnXoaKT.Size = new System.Drawing.Size(106, 41);
            this.btnXoaKT.TabIndex = 11;
            this.btnXoaKT.Text = "     Xóa ";
            this.btnXoaKT.UseVisualStyleBackColor = true;
            this.btnXoaKT.Click += new System.EventHandler(this.btnXoaKT_Click);
            // 
            // btnThoatKT
            // 
            this.btnThoatKT.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatKT.Image")));
            this.btnThoatKT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatKT.Location = new System.Drawing.Point(674, 310);
            this.btnThoatKT.Name = "btnThoatKT";
            this.btnThoatKT.Size = new System.Drawing.Size(124, 41);
            this.btnThoatKT.TabIndex = 12;
            this.btnThoatKT.Text = "      Thoát ";
            this.btnThoatKT.UseVisualStyleBackColor = true;
            this.btnThoatKT.Click += new System.EventHandler(this.btnThoatKT_Click);
            // 
            // richThanhTich
            // 
            this.richThanhTich.Location = new System.Drawing.Point(492, 176);
            this.richThanhTich.Name = "richThanhTich";
            this.richThanhTich.Size = new System.Drawing.Size(375, 96);
            this.richThanhTich.TabIndex = 13;
            this.richThanhTich.Text = "";
            this.richThanhTich.TextChanged += new System.EventHandler(this.richThanhTich_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(252, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "THÀNH TÍCH KHEN THƯỞNG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã Đoàn Viên ;";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 27);
            this.textBox1.TabIndex = 16;
            // 
            // fKhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richThanhTich);
            this.Controls.Add(this.btnThoatKT);
            this.Controls.Add(this.btnXoaKT);
            this.Controls.Add(this.btnSuaKT);
            this.Controls.Add(this.btnThemKT);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.txtTenKT);
            this.Controls.Add(this.txtMaKT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataKhenThuong);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fKhenThuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khen Thưởng";
            this.Load += new System.EventHandler(this.fKhenThuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKhenThuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataKhenThuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaKT;
        private System.Windows.Forms.TextBox txtTenKT;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Button btnThemKT;
        private System.Windows.Forms.Button btnSuaKT;
        private System.Windows.Forms.Button btnXoaKT;
        private System.Windows.Forms.Button btnThoatKT;
        private System.Windows.Forms.RichTextBox richThanhTich;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}