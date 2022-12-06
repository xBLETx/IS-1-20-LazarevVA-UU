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
    
    public partial class ZD3 : Form
    {
        static MySqlConnection conn;
        static MySqlCommand cmd;
        public class Con
        {
            static public MySqlConnection Conn1()
            {
                
                //string connStr = "server=10.90.12.110;port=33333;user=st_1_20_18;database=is_1_20_st18_KURS;password=54276237;";
                string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_18;database=is_1_20_st18_KURS;password=54276237;";
                
                MySqlConnection connDB;

                connDB = new MySqlConnection(connStr);

                return connDB;
            }
        }
        
        static public MySqlCommand Data()
        {

            
            string Select = "SELECT OrderMain.idOrder, OrderMain.clientOrder, OrderMain.Typeofelectronic, OrderMain.Manufacturer, OrderMain.uslugaOrder, OrderMain.Hasaccepted, OrderMain.orderstatus FROM OrderMain INNER JOIN Client ON OrderMain.clientOrder = Client.idClient INNER JOIN TypeOfElect ON OrderMain.Typeofelectronic = TypeOfElect.idtypeofelectronics INNER JOIN Manufacturers ON OrderMain.Manufacturer = Manufacturers.idManuf INNER JOIN PriceList ON OrderMain.uslugaOrder = PriceList.idpricelist INNER JOIN Employee ON OrderMain.Hasaccepted = Employee.idempl INNER JOIN OrderStatus ON OrderMain.orderstatus = OrderStatus.idOrderStatus";
            MySqlCommand cmd1 = new MySqlCommand(Select, conn);
            return cmd1;
        }
        public ZD3()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            menu menu1 = new menu();
            menu1.Show();
        }

        private void ZD3_Load(object sender, EventArgs e)
        {
            try
            {
                conn = Con.Conn1();
                conn.Open();
                cmd = Data();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    int Add = dataGridView1.Rows.Add();
                    dataGridView1.Rows[Add].Cells[0].Value = read[0].ToString();
                    dataGridView1.Rows[Add].Cells[1].Value = read[1].ToString();
                    dataGridView1.Rows[Add].Cells[2].Value = read[2].ToString();
                    dataGridView1.Rows[Add].Cells[3].Value = read[3].ToString();
                    dataGridView1.Rows[Add].Cells[4].Value = read[4].ToString();
                    dataGridView1.Rows[Add].Cells[5].Value = read[5].ToString();
                    dataGridView1.Rows[Add].Cells[6].Value = read[6].ToString();
                }
                read.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка при получении данных!\n или ошибка подключения\n {ex}");
            }
            finally
            {
                conn.Close();
            }


        }

       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int Order = e.RowIndex;
            string productId = dataGridView1.Rows[Order].Cells[0].Value.ToString();
            try
            {
                conn.Open();
                cmd = Data();
                MySqlDataReader read = cmd.ExecuteReader();
                string MessageBox1 = "";

                while (read.Read())
                {
                    MessageBox1 += $"Номер заказа: {read[0].ToString()}\n Клиент: {read[1].ToString()}\n Тип электроники: {read[2].ToString()}\n" +
                        $"Производитель: {read[3].ToString()}\n Тип услуги: {read[4].ToString()}\n Принял: {read[5].ToString()}\n Статус: {read[6].ToString()}\n";


                }
                read.Close();
                MessageBox.Show(MessageBox1);
            }
            catch
            {
                MessageBox.Show("Ошибка при получении данных о продукте!");

            }
            finally
            {
                conn.Close();
            }

        }
    }
}
