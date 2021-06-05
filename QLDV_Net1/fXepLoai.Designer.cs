
namespace QLDV_Net1
{
    partial class fXepLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fXepLoai));
            this.dataXepLoai = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.txtXepLoai = new System.Windows.Forms.TextBox();
            this.btnThemXL = new System.Windows.Forms.Button();
            this.btnSuaXL = new System.Windows.Forms.Button();
            this.btnXoaXL = new System.Windows.Forms.Button();
            this.btnThoatXL = new System.Windows.Forms.Button();
            this.richXepLoai = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataXepLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // dataXepLoai
            // 
            this.dataXepLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataXepLoai.Location = new System.Drawing.Point(0, 361);
            this.dataXepLoai.Name = "dataXepLoai";
            this.dataXepLoai.RowHeadersWidth = 51;
            this.dataXepLoai.RowTemplate.Height = 24;
            this.dataXepLoai.Size = new System.Drawing.Size(900, 172);
            this.dataXepLoai.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(48, 122);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(44, 19);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID* :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm Học* :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhận Xét :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Xếp Loại ĐV* :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(167, 119);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(171, 27);
            this.txtID.TabIndex = 5;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(167, 160);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(171, 27);
            this.txtNamHoc.TabIndex = 6;
            // 
            // txtXepLoai
            // 
            this.txtXepLoai.Location = new System.Drawing.Point(501, 160);
            this.txtXepLoai.Name = "txtXepLoai";
            this.txtXepLoai.Size = new System.Drawing.Size(332, 27);
            this.txtXepLoai.TabIndex = 8;
            this.txtXepLoai.TextChanged += new System.EventHandler(this.txtXepLoai_TextChanged);
            // 
            // btnThemXL
            // 
            this.btnThemXL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThemXL.FlatAppearance.BorderSize = 2;
            this.btnThemXL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThemXL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThemXL.Image = ((System.Drawing.Image)(resources.GetObject("btnThemXL.Image")));
            this.btnThemXL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemXL.Location = new System.Drawing.Point(66, 303);
            this.btnThemXL.Name = "btnThemXL";
            this.btnThemXL.Size = new System.Drawing.Size(127, 39);
            this.btnThemXL.TabIndex = 9;
            this.btnThemXL.Text = "Thêm Mới";
            this.btnThemXL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemXL.UseVisualStyleBackColor = true;
            this.btnThemXL.Click += new System.EventHandler(this.btnThemXL_Click);
            // 
            // btnSuaXL
            // 
            this.btnSuaXL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSuaXL.FlatAppearance.BorderSize = 2;
            this.btnSuaXL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSuaXL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSuaXL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuaXL.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaXL.Image")));
            this.btnSuaXL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaXL.Location = new System.Drawing.Point(296, 303);
            this.btnSuaXL.Name = "btnSuaXL";
            this.btnSuaXL.Size = new System.Drawing.Size(119, 39);
            this.btnSuaXL.TabIndex = 10;
            this.btnSuaXL.Text = "Chỉnh Sửa";
            this.btnSuaXL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaXL.UseVisualStyleBackColor = true;
            this.btnSuaXL.Click += new System.EventHandler(this.btnSuaXL_Click);
            // 
            // btnXoaXL
            // 
            this.btnXoaXL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoaXL.FlatAppearance.BorderSize = 2;
            this.btnXoaXL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoaXL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoaXL.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaXL.Image")));
            this.btnXoaXL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaXL.Location = new System.Drawing.Point(533, 303);
            this.btnXoaXL.Name = "btnXoaXL";
            this.btnXoaXL.Size = new System.Drawing.Size(112, 39);
            this.btnXoaXL.TabIndex = 11;
            this.btnXoaXL.Text = "  Xóa";
            this.btnXoaXL.UseVisualStyleBackColor = true;
            this.btnXoaXL.Click += new System.EventHandler(this.btnXoaXL_Click);
            // 
            // btnThoatXL
            // 
            this.btnThoatXL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoatXL.FlatAppearance.BorderSize = 2;
            this.btnThoatXL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoatXL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoatXL.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatXL.Image")));
            this.btnThoatXL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatXL.Location = new System.Drawing.Point(729, 303);
            this.btnThoatXL.Name = "btnThoatXL";
            this.btnThoatXL.Size = new System.Drawing.Size(114, 39);
            this.btnThoatXL.TabIndex = 12;
            this.btnThoatXL.Text = "      Thoát";
            this.btnThoatXL.UseVisualStyleBackColor = true;
            this.btnThoatXL.Click += new System.EventHandler(this.btnThoatXL_Click);
            // 
            // richXepLoai
            // 
            this.richXepLoai.Location = new System.Drawing.Point(501, 204);
            this.richXepLoai.Name = "richXepLoai";
            this.richXepLoai.Size = new System.Drawing.Size(332, 75);
            this.richXepLoai.TabIndex = 13;
            this.richXepLoai.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(301, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "XẾP LOẠI ĐOÀN VIÊN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã Đoàn Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã Hoạt Động";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 27);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(501, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(332, 27);
            this.textBox2.TabIndex = 18;
            // 
            // fXepLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richXepLoai);
            this.Controls.Add(this.btnThoatXL);
            this.Controls.Add(this.btnXoaXL);
            this.Controls.Add(this.btnSuaXL);
            this.Controls.Add(this.btnThemXL);
            this.Controls.Add(this.txtXepLoai);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dataXepLoai);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fXepLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xếp Loại";
            this.Load += new System.EventHandler(this.fXepLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataXepLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataXepLoai;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.TextBox txtXepLoai;
        private System.Windows.Forms.Button btnThemXL;
        private System.Windows.Forms.Button btnSuaXL;
        private System.Windows.Forms.Button btnXoaXL;
        private System.Windows.Forms.Button btnThoatXL;
        private System.Windows.Forms.RichTextBox richXepLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}