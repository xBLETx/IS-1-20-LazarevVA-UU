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
    public partial class ZD5 : Form
    {
        static MySqlConnection conn;
        public ZD5()
        {
            InitializeComponent();
        }
        public void data()
        {
            conn = ConnectDB.Class1.Con.Conn1();
            conn.Open();
            string zap = "SELECT * FROM t_Uchebka_Lazarev";
            MySqlCommand cmd = new MySqlCommand(zap, conn);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                int Add = dataGridView1.Rows.Add();
                dataGridView1.Rows[Add].Cells[0].Value = read[0].ToString();
                dataGridView1.Rows[Add].Cells[1].Value = read[1].ToString();
                dataGridView1.Rows[Add].Cells[2].Value = read[2].ToString();

            }
            read.Close();
            conn.Close();
            guna2TextBox1.Text = "";
        }
        private void ZD5_Load(object sender, EventArgs e)
        {
            data();

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string fio = guna2TextBox1.Text;
            //string Inser = $"INSER INTO t_Uchebka_Lazarev (fioStud) VALUES (\"{fio}\");";
            string Inser = $"INSERT INTO t_Uchebka_Lazarev (fioStud,datetimeStud) VALUES (\"{fio}\",CURRENT_TIMESTAMP)";
            MySqlCommand cmd = new MySqlCommand(Inser, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            data();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            menu menu1 = new menu();
            menu1.Show();
        }
    }
}
