
namespace QLDV_Net1
{
    partial class fChiDoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChiDoan));
            this.dataChiDoan = new System.Windows.Forms.DataGridView();
            this.btnThemCD = new System.Windows.Forms.Button();
            this.btnSuaCD = new System.Windows.Forms.Button();
            this.btnXoaCD = new System.Windows.Forms.Button();
            this.btnThoatCD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaChiDoan = new System.Windows.Forms.TextBox();
            this.txtTenChiDoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataChiDoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataChiDoan
            // 
            this.dataChiDoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataChiDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChiDoan.Location = new System.Drawing.Point(1, 355);
            this.dataChiDoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataChiDoan.Name = "dataChiDoan";
            this.dataChiDoan.RowHeadersWidth = 51;
            this.dataChiDoan.RowTemplate.Height = 24;
            this.dataChiDoan.Size = new System.Drawing.Size(898, 178);
            this.dataChiDoan.TabIndex = 0;
            this.dataChiDoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataChiDoan_CellContentClick);
            // 
            // btnThemCD
            // 
            this.btnThemCD.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnThemCD.FlatAppearance.BorderSize = 2;
            this.btnThemCD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnThemCD.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCD.Image")));
            this.btnThemCD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCD.Location = new System.Drawing.Point(41, 298);
            this.btnThemCD.Name = "btnThemCD";
            this.btnThemCD.Size = new System.Drawing.Size(155, 39);
            this.btnThemCD.TabIndex = 1;
            this.btnThemCD.Text = "Thêm Chi Đoàn";
            this.btnThemCD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCD.UseVisualStyleBackColor = true;
            this.btnThemCD.Click += new System.EventHandler(this.btnThemCD_Click);
            // 
            // btnSuaCD
            // 
            this.btnSuaCD.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaCD.Image")));
            this.btnSuaCD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaCD.Location = new System.Drawing.Point(257, 298);
            this.btnSuaCD.Name = "btnSuaCD";
            this.btnSuaCD.Size = new System.Drawing.Size(155, 39);
            this.btnSuaCD.TabIndex = 2;
            this.btnSuaCD.Text = "     Sửa Chi Đoàn";
            this.btnSuaCD.UseVisualStyleBackColor = true;
            this.btnSuaCD.Click += new System.EventHandler(this.btnSuaCD_Click);
            // 
            // btnXoaCD
            // 
            this.btnXoaCD.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCD.Image")));
            this.btnXoaCD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCD.Location = new System.Drawing.Point(477, 298);
            this.btnXoaCD.Name = "btnXoaCD";
            this.btnXoaCD.Size = new System.Drawing.Size(155, 39);
            this.btnXoaCD.TabIndex = 3;
            this.btnXoaCD.Text = "Xóa Chi Đoàn";
            this.btnXoaCD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCD.UseVisualStyleBackColor = true;
            this.btnXoaCD.Click += new System.EventHandler(this.btnXoaCD_Click);
            // 
            // btnThoatCD
            // 
            this.btnThoatCD.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatCD.Image")));
            this.btnThoatCD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatCD.Location = new System.Drawing.Point(693, 298);
            this.btnThoatCD.Name = "btnThoatCD";
            this.btnThoatCD.Size = new System.Drawing.Size(155, 39);
            this.btnThoatCD.TabIndex = 4;
            this.btnThoatCD.Text = "Thoát Chi Đoàn";
            this.btnThoatCD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatCD.UseVisualStyleBackColor = true;
            this.btnThoatCD.Click += new System.EventHandler(this.btnThoatCD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập Mã Chi Đoàn* :\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập Tên Chi Đoàn* :";
            // 
            // txtMaChiDoan
            // 
            this.txtMaChiDoan.Location = new System.Drawing.Point(270, 116);
            this.txtMaChiDoan.Name = "txtMaChiDoan";
            this.txtMaChiDoan.Size = new System.Drawing.Size(281, 27);
            this.txtMaChiDoan.TabIndex = 7;
            this.txtMaChiDoan.TextChanged += new System.EventHandler(this.txtMaChiDoan_TextChanged);
            // 
            // txtTenChiDoan
            // 
            this.txtTenChiDoan.Location = new System.Drawing.Point(270, 180);
            this.txtTenChiDoan.Name = "txtTenChiDoan";
            this.txtTenChiDoan.Size = new System.Drawing.Size(281, 27);
            this.txtTenChiDoan.TabIndex = 8;
            this.txtTenChiDoan.TextChanged += new System.EventHandler(this.txtTenChiDoan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(288, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "THÔNG TIN CHI ĐOÀN";
            // 
            // fChiDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenChiDoan);
            this.Controls.Add(this.txtMaChiDoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoatCD);
            this.Controls.Add(this.btnXoaCD);
            this.Controls.Add(this.btnSuaCD);
            this.Controls.Add(this.btnThemCD);
            this.Controls.Add(this.dataChiDoan);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fChiDoan";
            this.Text = "Chi Đoàn";
            this.Load += new System.EventHandler(this.fChiDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataChiDoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataChiDoan;
        private System.Windows.Forms.Button btnThemCD;
        private System.Windows.Forms.Button btnSuaCD;
        private System.Windows.Forms.Button btnXoaCD;
        private System.Windows.Forms.Button btnThoatCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaChiDoan;
        private System.Windows.Forms.TextBox txtTenChiDoan;
        private System.Windows.Forms.Label label3;
    }
}

