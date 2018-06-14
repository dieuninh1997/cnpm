namespace QLBanDoGo
{
    partial class FormBanHangIn
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
            this.dgvDsHangHoaMua = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTongTien = new System.Windows.Forms.NumericUpDown();
            this.nudTienMat = new System.Windows.Forms.NumericUpDown();
            this.nudTienTra = new System.Windows.Forms.NumericUpDown();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHangHoaMua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienTra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDsHangHoaMua
            // 
            this.dgvDsHangHoaMua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsHangHoaMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsHangHoaMua.Location = new System.Drawing.Point(12, 32);
            this.dgvDsHangHoaMua.Name = "dgvDsHangHoaMua";
            this.dgvDsHangHoaMua.Size = new System.Drawing.Size(426, 266);
            this.dgvDsHangHoaMua.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách hàng hóa mua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiền mặt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiền trả";
            // 
            // nudTongTien
            // 
            this.nudTongTien.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTongTien.Location = new System.Drawing.Point(70, 336);
            this.nudTongTien.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudTongTien.Name = "nudTongTien";
            this.nudTongTien.ReadOnly = true;
            this.nudTongTien.Size = new System.Drawing.Size(201, 20);
            this.nudTongTien.TabIndex = 5;
            // 
            // nudTienMat
            // 
            this.nudTienMat.Location = new System.Drawing.Point(70, 368);
            this.nudTienMat.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudTienMat.Name = "nudTienMat";
            this.nudTienMat.Size = new System.Drawing.Size(201, 20);
            this.nudTienMat.TabIndex = 6;
            this.nudTienMat.ValueChanged += new System.EventHandler(this.nudTienMat_ValueChanged);
            // 
            // nudTienTra
            // 
            this.nudTienTra.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTienTra.Location = new System.Drawing.Point(70, 402);
            this.nudTienTra.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudTienTra.Name = "nudTienTra";
            this.nudTienTra.ReadOnly = true;
            this.nudTienTra.Size = new System.Drawing.Size(201, 20);
            this.nudTienTra.TabIndex = 7;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(313, 338);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(115, 79);
            this.btnIn.TabIndex = 8;
            this.btnIn.Text = "IN HÓA ĐƠN";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // FormBanHangIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 447);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.nudTienTra);
            this.Controls.Add(this.nudTienMat);
            this.Controls.Add(this.nudTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDsHangHoaMua);
            this.Name = "FormBanHangIn";
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.FormBanHangIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHangHoaMua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTongTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsHangHoaMua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTongTien;
        private System.Windows.Forms.NumericUpDown nudTienMat;
        private System.Windows.Forms.NumericUpDown nudTienTra;
        private System.Windows.Forms.Button btnIn;
    }
}