using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2111886_Lab2_Bai1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiBai1_Click(object sender, EventArgs e)
        {
            var form = new frmBai1();
            form.ShowDialog();
        }

        private void tsmiBai2_Click(object sender, EventArgs e)
        {
            var form = new fmBai2();
            form.ShowDialog();
        }

        private void tsmiBai3_Click(object sender, EventArgs e)
        {
            var form = new FrmBai3();
            form.ShowDialog();
        }
    }
}
