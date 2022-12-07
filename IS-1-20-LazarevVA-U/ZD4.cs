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
        public void datasql()
        {
            conn = ConnectDB.Class1.Con.Conn1();
            conn.Open();
            string request = "SELECT * FROM t_datatime";
            MySqlCommand cmd = new MySqlCommand(request, conn);


            MySqlDataReader read = cmd.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (read.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = read[0].ToString();
                data[data.Count - 1][1] = read[1].ToString();
                data[data.Count - 1][2] = read[2].ToString();
                data[data.Count - 1][3] = read[3].ToString();
            }
            read.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }
        public void evet1()
        {
            conn.Open();
            string request = "SELECT photoUrl FROM t_datatime";
            MySqlCommand cmd = new MySqlCommand(request, conn);

            string sprite = cmd.ExecuteScalar().ToString();
            pictureBox1.ImageLocation = sprite;
            conn.Close();
        }
        
        public ZD4()
        {
            InitializeComponent();
        }

        private void ZD4_Load(object sender, EventArgs e)
        {
            datasql();
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            evet1();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            menu menu1 = new menu();
            menu1.Show();
        }
    }
}
