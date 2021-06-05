
namespace QLDV_Net1
{
    partial class fHoatDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHoatDong));
            this.dataHoatDong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemHĐ = new System.Windows.Forms.Button();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnThoatHD = new System.Windows.Forms.Button();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTenHD = new System.Windows.Forms.TextBox();
            this.richGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtThoiGianToChuc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoatDong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHoatDong
            // 
            this.dataHoatDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoatDong.Location = new System.Drawing.Point(1, 374);
            this.dataHoatDong.Name = "dataHoatDong";
            this.dataHoatDong.RowHeadersWidth = 51;
            this.dataHoatDong.RowTemplate.Height = 24;
            this.dataHoatDong.Size = new System.Drawing.Size(898, 160);
            this.dataHoatDong.TabIndex = 0;
            this.dataHoatDong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHoatDong_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hoạt Động* :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Hoạt Động* :\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thời Gian Tổ Chức* :\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ghi Chú";
            // 
            // btnThemHĐ
            // 
            this.btnThemHĐ.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHĐ.Image")));
            this.btnThemHĐ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHĐ.Location = new System.Drawing.Point(35, 315);
            this.btnThemHĐ.Name = "btnThemHĐ";
            this.btnThemHĐ.Size = new System.Drawing.Size(122, 40);
            this.btnThemHĐ.TabIndex = 5;
            this.btnThemHĐ.Text = "Thêm Mới";
            this.btnThemHĐ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHĐ.UseVisualStyleBackColor = true;
            this.btnThemHĐ.Click += new System.EventHandler(this.btnThemHĐ_Click);
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaHD.Image")));
            this.btnSuaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaHD.Location = new System.Drawing.Point(276, 315);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(118, 40);
            this.btnSuaHD.TabIndex = 6;
            this.btnSuaHD.Text = "Chỉnh Sửa\r\n";
            this.btnSuaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaHD.UseVisualStyleBackColor = true;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHD.Image")));
            this.btnXoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHD.Location = new System.Drawing.Point(499, 315);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(104, 40);
            this.btnXoaHD.TabIndex = 7;
            this.btnXoaHD.Text = "     Xóa ";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnThoatHD
            // 
            this.btnThoatHD.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatHD.Image")));
            this.btnThoatHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatHD.Location = new System.Drawing.Point(702, 315);
            this.btnThoatHD.Name = "btnThoatHD";
            this.btnThoatHD.Size = new System.Drawing.Size(109, 40);
            this.btnThoatHD.TabIndex = 8;
            this.btnThoatHD.Text = "     Thoát ";
            this.btnThoatHD.UseVisualStyleBackColor = true;
            this.btnThoatHD.Click += new System.EventHandler(this.btnThoatHD_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(173, 111);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(185, 27);
            this.txtMaHD.TabIndex = 9;
            // 
            // txtTenHD
            // 
            this.txtTenHD.Location = new System.Drawing.Point(173, 207);
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(185, 27);
            this.txtTenHD.TabIndex = 10;
            // 
            // richGhiChu
            // 
            this.richGhiChu.Location = new System.Drawing.Point(540, 185);
            this.richGhiChu.Name = "richGhiChu";
            this.richGhiChu.Size = new System.Drawing.Size(264, 96);
            this.richGhiChu.TabIndex = 12;
            this.richGhiChu.Text = "";
            // 
            // txtThoiGianToChuc
            // 
            this.txtThoiGianToChuc.Location = new System.Drawing.Point(540, 108);
            this.txtThoiGianToChuc.Mask = "00/00/0000 90:00";
            this.txtThoiGianToChuc.Name = "txtThoiGianToChuc";
            this.txtThoiGianToChuc.Size = new System.Drawing.Size(264, 27);
            this.txtThoiGianToChuc.TabIndex = 13;
            this.txtThoiGianToChuc.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(246, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "HOẠT ĐỘNG CỦA ĐOÀN VIÊN";
            // 
            // fHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtThoiGianToChuc);
            this.Controls.Add(this.richGhiChu);
            this.Controls.Add(this.txtTenHD);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.btnThoatHD);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.btnSuaHD);
            this.Controls.Add(this.btnThemHĐ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataHoatDong);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fHoatDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoạt Động";
            this.Load += new System.EventHandler(this.fHoatDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHoatDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHoatDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemHĐ;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnThoatHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtTenHD;
        private System.Windows.Forms.RichTextBox richGhiChu;
        private System.Windows.Forms.MaskedTextBox txtThoiGianToChuc;
        private System.Windows.Forms.Label label5;
    }
}