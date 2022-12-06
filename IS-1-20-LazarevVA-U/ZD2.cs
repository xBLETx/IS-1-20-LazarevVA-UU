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

namespace IS_1_20_LazarevVA_U
{
    public partial class ZD2 : Form
    {
        MySqlConnection conn;
        public class Con
        {
            static public MySqlConnection Conn1()
            {
                // строка подключения к БД
                //string connStr = "server=10.90.12.110;port=33333;user=st_1_20_18;database=is_1_20_st18_KURS;password=54276237;";
                string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_18;database=is_1_20_st18_KURS;password=54276237;";
                
                //Переменная соединения
                MySqlConnection connDB;

                connDB = new MySqlConnection(connStr);

                return connDB;
            }
        }
        
        public ZD2()
        {
            InitializeComponent();
        }

        private void ZD2_Load(object sender, EventArgs e)
        {
            try
            {
                conn = Con.Conn1();
                conn.Open();
                MessageBox.Show("Всё гуд");

            }
            catch
            {
                MessageBox.Show("Ошибка подключения");
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            menu menu1 = new menu();
            menu1.Show();
        }
    }
}
