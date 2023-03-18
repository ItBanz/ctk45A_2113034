namespace _2111885_Lab1
{
    partial class MainForm
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
            this.TEXTTEN = new System.Windows.Forms.TextBox();
            this.XuLy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaoChep = new System.Windows.Forms.TextBox();
            this.Saochep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên:";
            // 
            // TEXTTEN
            // 
            this.TEXTTEN.Location = new System.Drawing.Point(160, 56);
            this.TEXTTEN.Name = "TEXTTEN";
            this.TEXTTEN.Size = new System.Drawing.Size(217, 20);
            this.TEXTTEN.TabIndex = 1;
            this.TEXTTEN.TextChanged += new System.EventHandler(this.TEXTTEN_TextChanged);
            // 
            // XuLy
            // 
            this.XuLy.Location = new System.Drawing.Point(186, 82);
            this.XuLy.Name = "XuLy";
            this.XuLy.Size = new System.Drawing.Size(75, 23);
            this.XuLy.TabIndex = 2;
            this.XuLy.Text = "Nhập";
            this.XuLy.UseVisualStyleBackColor = true;
            this.XuLy.Click += new System.EventHandler(this.XuLy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bạn đã nhập: ";
            // 
            // txtSaoChep
            // 
            this.txtSaoChep.Location = new System.Drawing.Point(160, 173);
            this.txtSaoChep.Name = "txtSaoChep";
            this.txtSaoChep.Size = new System.Drawing.Size(217, 20);
            this.txtSaoChep.TabIndex = 6;
            this.txtSaoChep.TextChanged += new System.EventHandler(this.txtSaoChep_TextChanged);
            // 
            // Saochep
            // 
            this.Saochep.Location = new System.Drawing.Point(285, 82);
            this.Saochep.Name = "Saochep";
            this.Saochep.Size = new System.Drawing.Size(75, 23);
            this.Saochep.TabIndex = 7;
            this.Saochep.Text = "Sao chép";
            this.Saochep.UseVisualStyleBackColor = true;
            this.Saochep.Click += new System.EventHandler(this.txtSaoChep_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Saochep);
            this.Controls.Add(this.txtSaoChep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XuLy);
            this.Controls.Add(this.TEXTTEN);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Chương trình đầu tiên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TEXTTEN;
        private System.Windows.Forms.Button XuLy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaoChep;
        private System.Windows.Forms.Button Saochep;
    }
}

