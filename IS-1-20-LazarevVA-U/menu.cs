using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_LazarevVA_U
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZD1 z1 = new ZD1();
            z1.Show();
            

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZD2 z2 = new ZD2();
            z2.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZD3 z3 = new ZD3();
            z3.Show();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZD4 z4 = new ZD4();
            z4.Show();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZD5 z5 = new ZD5();
            z5.Show();
        }
    }
}
