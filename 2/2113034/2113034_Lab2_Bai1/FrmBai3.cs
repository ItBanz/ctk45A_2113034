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
    public partial class FrmBai3 : Form
    {
        List<string> list = new List<string>();
        public FrmBai3()
        {
            InitializeComponent();
        }

        private void btmThem_Click(object sender, EventArgs e)
        {
            var tu = txtTumoi.Text;
            var Nghia = txtNghia.Text;
            listBox1.Items.Add(tu);
            list.Add(Nghia);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = listBox1.SelectedIndex;
            textBox1.Text = list[stt];
        }
    }
}
