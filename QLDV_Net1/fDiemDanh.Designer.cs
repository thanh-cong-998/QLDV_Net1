
namespace QLDV_Net1
{
    partial class fDiemDanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDiemDanh));
            this.dataDiemDanh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDD = new System.Windows.Forms.TextBox();
            this.btnThemDD = new System.Windows.Forms.Button();
            this.btnSuaDD = new System.Windows.Forms.Button();
            this.btnXoaDD = new System.Windows.Forms.Button();
            this.btnThoatDD = new System.Windows.Forms.Button();
            this.richtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDiemDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDiemDanh
            // 
            this.dataDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDiemDanh.Location = new System.Drawing.Point(2, 372);
            this.dataDiemDanh.Name = "dataDiemDanh";
            this.dataDiemDanh.RowHeadersWidth = 51;
            this.dataDiemDanh.RowTemplate.Height = 24;
            this.dataDiemDanh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataDiemDanh.Size = new System.Drawing.Size(899, 150);
            this.dataDiemDanh.TabIndex = 0;
            this.dataDiemDanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDiemDanh_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Điểm Danh* :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ghi Chú :";
            // 
            // txtDD
            // 
            this.txtDD.Location = new System.Drawing.Point(186, 119);
            this.txtDD.Name = "txtDD";
            this.txtDD.Size = new System.Drawing.Size(273, 27);
            this.txtDD.TabIndex = 3;
            this.txtDD.TextChanged += new System.EventHandler(this.txtDD_TextChanged);
            // 
            // btnThemDD
            // 
            this.btnThemDD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThemDD.FlatAppearance.BorderSize = 2;
            this.btnThemDD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThemDD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThemDD.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDD.Image")));
            this.btnThemDD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDD.Location = new System.Drawing.Point(52, 320);
            this.btnThemDD.Name = "btnThemDD";
            this.btnThemDD.Size = new System.Drawing.Size(124, 41);
            this.btnThemDD.TabIndex = 5;
            this.btnThemDD.Text = "Thêm Mới";
            this.btnThemDD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDD.UseVisualStyleBackColor = true;
            this.btnThemDD.Click += new System.EventHandler(this.btnThemDD_Click);
            // 
            // btnSuaDD
            // 
            this.btnSuaDD.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaDD.Image")));
            this.btnSuaDD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDD.Location = new System.Drawing.Point(260, 320);
            this.btnSuaDD.Name = "btnSuaDD";
            this.btnSuaDD.Size = new System.Drawing.Size(122, 41);
            this.btnSuaDD.TabIndex = 6;
            this.btnSuaDD.Text = "Chỉnh Sửa";
            this.btnSuaDD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDD.UseVisualStyleBackColor = true;
            this.btnSuaDD.Click += new System.EventHandler(this.btnSuaDD_Click);
            // 
            // btnXoaDD
            // 
            this.btnXoaDD.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDD.Image")));
            this.btnXoaDD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDD.Location = new System.Drawing.Point(485, 320);
            this.btnXoaDD.Name = "btnXoaDD";
            this.btnXoaDD.Size = new System.Drawing.Size(108, 41);
            this.btnXoaDD.TabIndex = 7;
            this.btnXoaDD.Text = "    Xóa";
            this.btnXoaDD.UseVisualStyleBackColor = true;
            this.btnXoaDD.Click += new System.EventHandler(this.btnXoaDD_Click);
            // 
            // btnThoatDD
            // 
            this.btnThoatDD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoatDD.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatDD.Image")));
            this.btnThoatDD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatDD.Location = new System.Drawing.Point(697, 320);
            this.btnThoatDD.Name = "btnThoatDD";
            this.btnThoatDD.Size = new System.Drawing.Size(110, 41);
            this.btnThoatDD.TabIndex = 8;
            this.btnThoatDD.Text = "    Thoát";
            this.btnThoatDD.UseVisualStyleBackColor = true;
            this.btnThoatDD.Click += new System.EventHandler(this.btnThoatDD_Click);
            // 
            // richtxtGhiChu
            // 
            this.richtxtGhiChu.Location = new System.Drawing.Point(186, 168);
            this.richtxtGhiChu.Name = "richtxtGhiChu";
            this.richtxtGhiChu.Size = new System.Drawing.Size(273, 96);
            this.richtxtGhiChu.TabIndex = 9;
            this.richtxtGhiChu.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(299, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "ĐIỂM DANH ĐOÀN VIÊN\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã Đoàn Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã Hoạt ĐỘng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(657, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 27);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(657, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 27);
            this.textBox2.TabIndex = 14;
            // 
            // fDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 534);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richtxtGhiChu);
            this.Controls.Add(this.btnThoatDD);
            this.Controls.Add(this.btnXoaDD);
            this.Controls.Add(this.btnSuaDD);
            this.Controls.Add(this.btnThemDD);
            this.Controls.Add(this.txtDD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDiemDanh);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fDiemDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm Danh";
            this.Load += new System.EventHandler(this.fDiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDiemDanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDiemDanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDD;
        private System.Windows.Forms.Button btnThemDD;
        private System.Windows.Forms.Button btnSuaDD;
        private System.Windows.Forms.Button btnXoaDD;
        private System.Windows.Forms.Button btnThoatDD;
        private System.Windows.Forms.RichTextBox richtxtGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}