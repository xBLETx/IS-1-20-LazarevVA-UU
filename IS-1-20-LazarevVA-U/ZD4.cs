using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConnectDB;

namespace IS_1_20_LazarevVA_U
{
    public partial class ZD4 : Form
    {
        MySqlConnection conn;
        
        
        public ZD4()
        {
            InitializeComponent();
        }

        private void ZD4_Load(object sender, EventArgs e)
        {
            conn = ConnectDB.Class1.Con.Conn1();
            conn.Open();
            string request = "SELECT * FROM t_datatime";
            MySqlCommand cmd = new MySqlCommand(request, conn);
            

            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                int row = dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = read[0].ToString();
                dataGridView1.Rows[row].Cells[1].Value = read[1].ToString();
                dataGridView1.Rows[row].Cells[2].Value = read[2].ToString();
                dataGridView1.Rows[row].Cells[3].Value = read[3].ToString();
            }
            read.Close();
           conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            string request = "SELECT photoUrl FROM t_datatime";
            MySqlCommand cmd = new MySqlCommand(request, conn);
            
            string sprite = cmd.ExecuteScalar().ToString();
            pictureBox1.ImageLocation = sprite;
            conn.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            menu menu1 = new menu();
            menu1.Show();
        }
    }
}
