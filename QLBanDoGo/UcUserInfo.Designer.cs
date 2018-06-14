namespace QLBanDoGo
{
    partial class UcUserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.gpChucNangNV = new System.Windows.Forms.GroupBox();
            this.btnBH_Xoa = new System.Windows.Forms.Button();
            this.btnBH_Sua = new System.Windows.Forms.Button();
            this.btnBH_Refresh = new System.Windows.Forms.Button();
            this.btnBH_Them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgaySinhNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCMT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pcAvatar = new System.Windows.Forms.PictureBox();
            this.gpChucNangNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và Tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(359, 91);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(298, 20);
            this.txtHoTenNV.TabIndex = 2;
            // 
            // gpChucNangNV
            // 
            this.gpChucNangNV.BackColor = System.Drawing.SystemColors.Control;
            this.gpChucNangNV.Controls.Add(this.btnBH_Xoa);
            this.gpChucNangNV.Controls.Add(this.btnBH_Sua);
            this.gpChucNangNV.Controls.Add(this.btnBH_Refresh);
            this.gpChucNangNV.Controls.Add(this.btnBH_Them);
            this.gpChucNangNV.Location = new System.Drawing.Point(59, 417);
            this.gpChucNangNV.Name = "gpChucNangNV";
            this.gpChucNangNV.Size = new System.Drawing.Size(852, 81);
            this.gpChucNangNV.TabIndex = 3;
            this.gpChucNangNV.TabStop = false;
            this.gpChucNangNV.Text = "Chức năng";
            // 
            // btnBH_Xoa
            // 
            this.btnBH_Xoa.Image = global::QLBanDoGo.Properties.Resources.delete1;
            this.btnBH_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBH_Xoa.Location = new System.Drawing.Point(97, 19);
            this.btnBH_Xoa.Name = "btnBH_Xoa";
            this.btnBH_Xoa.Size = new System.Drawing.Size(75, 49);
            this.btnBH_Xoa.TabIndex = 4;
            this.btnBH_Xoa.Text = "Xóa";
            this.btnBH_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBH_Xoa.UseVisualStyleBackColor = true;
            // 
            // btnBH_Sua
            // 
            this.btnBH_Sua.Image = global::QLBanDoGo.Properties.Resources.edit;
            this.btnBH_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBH_Sua.Location = new System.Drawing.Point(178, 19);
            this.btnBH_Sua.Name = "btnBH_Sua";
            this.btnBH_Sua.Size = new System.Drawing.Size(75, 49);
            this.btnBH_Sua.TabIndex = 5;
            this.btnBH_Sua.Text = "Sửa";
            this.btnBH_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBH_Sua.UseVisualStyleBackColor = true;
            // 
            // btnBH_Refresh
            // 
            this.btnBH_Refresh.Image = global::QLBanDoGo.Properties.Resources.reload;
            this.btnBH_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBH_Refresh.Location = new System.Drawing.Point(259, 19);
            this.btnBH_Refresh.Name = "btnBH_Refresh";
            this.btnBH_Refresh.Size = new System.Drawing.Size(75, 49);
            this.btnBH_Refresh.TabIndex = 6;
            this.btnBH_Refresh.Text = "Refresh";
            this.btnBH_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBH_Refresh.UseVisualStyleBackColor = true;
            // 
            // btnBH_Them
            // 
            this.btnBH_Them.Image = global::QLBanDoGo.Properties.Resources.plus;
            this.btnBH_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBH_Them.Location = new System.Drawing.Point(16, 19);
            this.btnBH_Them.Name = "btnBH_Them";
            this.btnBH_Them.Size = new System.Drawing.Size(75, 49);
            this.btnBH_Them.TabIndex = 1;
            this.btnBH_Them.Text = "Thêm";
            this.btnBH_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBH_Them.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(970, 30);
            this.label3.TabIndex = 5;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNgaySinhNV
            // 
            this.txtNgaySinhNV.Location = new System.Drawing.Point(359, 130);
            this.txtNgaySinhNV.Name = "txtNgaySinhNV";
            this.txtNgaySinhNV.Size = new System.Drawing.Size(298, 20);
            this.txtNgaySinhNV.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới tính";
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(359, 176);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(47, 17);
            this.radioNam.TabIndex = 9;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(498, 176);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(39, 17);
            this.radioNu.TabIndex = 10;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Location = new System.Drawing.Point(359, 213);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(298, 20);
            this.txtDiaChiNV.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Địa chỉ";
            // 
            // txtCMT
            // 
            this.txtCMT.Location = new System.Drawing.Point(359, 251);
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.Size = new System.Drawing.Size(298, 20);
            this.txtCMT.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số CMT";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(359, 291);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(298, 20);
            this.txtSDT.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số điện thoại";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(774, 88);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(137, 20);
            this.txtMaNV.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(710, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mã NV";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(774, 131);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(137, 20);
            this.txtChucVu.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(710, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Chức vụ";
            // 
            // pcAvatar
            // 
            this.pcAvatar.Image = global::QLBanDoGo.Properties.Resources.ninh;
            this.pcAvatar.Location = new System.Drawing.Point(59, 91);
            this.pcAvatar.Name = "pcAvatar";
            this.pcAvatar.Size = new System.Drawing.Size(162, 220);
            this.pcAvatar.TabIndex = 0;
            this.pcAvatar.TabStop = false;
            // 
            // UcUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCMT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiaChiNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioNu);
            this.Controls.Add(this.radioNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNgaySinhNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpChucNangNV);
            this.Controls.Add(this.txtHoTenNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcAvatar);
            this.Name = "UcUserInfo";
            this.Size = new System.Drawing.Size(970, 534);
            this.Load += new System.EventHandler(this.UcUserInfo_Load);
            this.gpChucNangNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.GroupBox gpChucNangNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNgaySinhNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.TextBox txtDiaChiNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCMT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBH_Them;
        private System.Windows.Forms.Button btnBH_Xoa;
        private System.Windows.Forms.Button btnBH_Sua;
        private System.Windows.Forms.Button btnBH_Refresh;
    }
}
