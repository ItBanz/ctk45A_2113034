namespace BaiTapWindowsForm
{
    partial class frmBai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTenHang = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.grbHinhThucThanhToan = new System.Windows.Forms.GroupBox();
            this.rdbChuyenKhoan = new System.Windows.Forms.RadioButton();
            this.rdbTienMat = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTinhTien = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.grbHinhThucThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng:";
            // 
            // cbbTenHang
            // 
            this.cbbTenHang.FormattingEnabled = true;
            this.cbbTenHang.Items.AddRange(new object[] {
            "Chuột",
            "Máy in",
            "Bàn phím"});
            this.cbbTenHang.Location = new System.Drawing.Point(137, 24);
            this.cbbTenHang.Name = "cbbTenHang";
            this.cbbTenHang.Size = new System.Drawing.Size(203, 21);
            this.cbbTenHang.TabIndex = 1;
            this.cbbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbbTenHang_SelectedIndexChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(137, 56);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(203, 20);
            this.txtDonGia.TabIndex = 2;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(137, 87);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(203, 20);
            this.txtSoLuong.TabIndex = 2;
            // 
            // grbHinhThucThanhToan
            // 
            this.grbHinhThucThanhToan.Controls.Add(this.rdbTienMat);
            this.grbHinhThucThanhToan.Controls.Add(this.rdbChuyenKhoan);
            this.grbHinhThucThanhToan.Location = new System.Drawing.Point(137, 128);
            this.grbHinhThucThanhToan.Name = "grbHinhThucThanhToan";
            this.grbHinhThucThanhToan.Size = new System.Drawing.Size(154, 75);
            this.grbHinhThucThanhToan.TabIndex = 3;
            this.grbHinhThucThanhToan.TabStop = false;
            this.grbHinhThucThanhToan.Text = "Hình thức thanh toán";
            // 
            // rdbChuyenKhoan
            // 
            this.rdbChuyenKhoan.AutoSize = true;
            this.rdbChuyenKhoan.Checked = true;
            this.rdbChuyenKhoan.Location = new System.Drawing.Point(22, 20);
            this.rdbChuyenKhoan.Name = "rdbChuyenKhoan";
            this.rdbChuyenKhoan.Size = new System.Drawing.Size(94, 17);
            this.rdbChuyenKhoan.TabIndex = 0;
            this.rdbChuyenKhoan.TabStop = true;
            this.rdbChuyenKhoan.Text = "Chuyển khoản";
            this.rdbChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // rdbTienMat
            // 
            this.rdbTienMat.AutoSize = true;
            this.rdbTienMat.Location = new System.Drawing.Point(22, 43);
            this.rdbTienMat.Name = "rdbTienMat";
            this.rdbTienMat.Size = new System.Drawing.Size(66, 17);
            this.rdbTienMat.TabIndex = 0;
            this.rdbTienMat.Text = "Tiền mặt";
            this.rdbTienMat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số tiền thanh toán:";
            // 
            // lblTinhTien
            // 
            this.lblTinhTien.AutoSize = true;
            this.lblTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTien.Location = new System.Drawing.Point(232, 257);
            this.lblTinhTien.Name = "lblTinhTien";
            this.lblTinhTien.Size = new System.Drawing.Size(14, 20);
            this.lblTinhTien.TabIndex = 0;
            this.lblTinhTien.Text = ".";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(171, 209);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 4;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.grbHinhThucThanhToan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.cbbTenHang);
            this.Controls.Add(this.lblTinhTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.Load += new System.EventHandler(this.frmBai2_Load);
            this.grbHinhThucThanhToan.ResumeLayout(false);
            this.grbHinhThucThanhToan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTenHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox grbHinhThucThanhToan;
        private System.Windows.Forms.RadioButton rdbTienMat;
        private System.Windows.Forms.RadioButton rdbChuyenKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTinhTien;
        private System.Windows.Forms.Button btnTinhTien;
    }
}