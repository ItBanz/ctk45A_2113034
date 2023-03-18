using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2111885_Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TEXTTEN_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = TEXTTEN.Text;
        }

        private void XuLy_Click(object sender, EventArgs e)
        {
            var tenDangNhap = TEXTTEN.Text;
            MessageBox.Show($"Wellcome homie {tenDangNhap}");
        }

   

  
        private void txtSaoChep_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = TEXTTEN.Text;
        }
    }
}
