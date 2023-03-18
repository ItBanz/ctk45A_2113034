namespace BaiTapWindowsForm
{
    partial class frmBai3
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
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTinhAB = new System.Windows.Forms.RadioButton();
            this.rdTinh1denN = new System.Windows.Forms.RadioButton();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a =";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số b =";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số n =";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(112, 31);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(163, 20);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.Text = "0";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(112, 70);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(163, 20);
            this.txtSoB.TabIndex = 1;
            this.txtSoB.Text = "0";
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(112, 109);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(163, 20);
            this.txtSoN.TabIndex = 1;
            this.txtSoN.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTinh1denN);
            this.groupBox1.Controls.Add(this.rdTinhAB);
            this.groupBox1.Location = new System.Drawing.Point(71, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rdTinhAB
            // 
            this.rdTinhAB.AutoSize = true;
            this.rdTinhAB.Checked = true;
            this.rdTinhAB.Location = new System.Drawing.Point(41, 28);
            this.rdTinhAB.Name = "rdTinhAB";
            this.rdTinhAB.Size = new System.Drawing.Size(114, 17);
            this.rdTinhAB.TabIndex = 0;
            this.rdTinhAB.TabStop = true;
            this.rdTinhAB.Text = "Tính tổng của a, b";
            this.rdTinhAB.UseVisualStyleBackColor = true;
            // 
            // rdTinh1denN
            // 
            this.rdTinh1denN.AutoSize = true;
            this.rdTinh1denN.Location = new System.Drawing.Point(41, 62);
            this.rdTinh1denN.Name = "rdTinh1denN";
            this.rdTinh1denN.Size = new System.Drawing.Size(124, 17);
            this.rdTinh1denN.TabIndex = 0;
            this.rdTinh1denN.Text = "Tính tổng từ 1 đến n";
            this.rdTinh1denN.UseVisualStyleBackColor = true;
            this.rdTinh1denN.CheckedChanged += new System.EventHandler(this.rdTinh1denN_CheckedChanged);
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(135, 261);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(75, 23);
            this.btnKetQua.TabIndex = 3;
            this.btnKetQua.Text = "Xem kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả là : ";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(142, 287);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(13, 18);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.Text = ".";
            this.lblKetQua.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 340);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTinh1denN;
        private System.Windows.Forms.RadioButton rdTinhAB;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetQua;
    }
}