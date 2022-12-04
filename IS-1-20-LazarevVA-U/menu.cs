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
    }
}
