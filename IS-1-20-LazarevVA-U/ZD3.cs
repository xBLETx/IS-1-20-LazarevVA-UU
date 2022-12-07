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

        

        static public MySqlCommand Data()
        {


            string Select = "SELECT OrderMain.idOrder, OrderMain.clientOrder, OrderMain.Typeofelectronic, OrderMain.Manufacturer, OrderMain.uslugaOrder, OrderMain.Hasaccepted, OrderMain.orderstatus FROM OrderMain INNER JOIN Client ON OrderMain.clientOrder = Client.idClient INNER JOIN TypeOfElect ON OrderMain.Typeofelectronic = TypeOfElect.idtypeofelectronics INNER JOIN Manufacturers ON OrderMain.Manufacturer = Manufacturers.idManuf INNER JOIN PriceList ON OrderMain.uslugaOrder = PriceList.idpricelist INNER JOIN Employee ON OrderMain.Hasaccepted = Employee.idempl INNER JOIN OrderStatus ON OrderMain.orderstatus = OrderStatus.idOrderStatus";
            MySqlCommand cmd1 = new MySqlCommand(Select, conn);
            return cmd1;
        }
        public void dataPrint()
        {
            try
            {
                conn = Con.Conn1();
                conn.Open();
                cmd = Data();
                MySqlDataReader read = cmd.ExecuteReader();
                List<string[]> data = new List<string[]>();//список

                while (read.Read())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = read[0].ToString();
                    data[data.Count - 1][1] = read[1].ToString();
                    data[data.Count - 1][2] = read[2].ToString();
                    data[data.Count - 1][3] = read[3].ToString();
                    data[data.Count - 1][4] = read[4].ToString();
                    data[data.Count - 1][5] = read[5].ToString();
                    data[data.Count - 1][6] = read[6].ToString();
                }
                read.Close();
                conn.Close();
                foreach (string[] s in data)//цыкл новые строки
                {
                    dataGridView1.Rows.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении данных!\n или ошибка подключения\n {ex}");
            }
            finally
            {
                conn.Close();
            }
        }
        public void eventClic1()
        {
            
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
        

        
        public ZD3()
        {
            InitializeComponent();
        }

       

        private void ZD3_Load(object sender, EventArgs e)
        {
            dataPrint();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            menu menu1 = new menu();
            menu1.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            eventClic1();

        }
    }
}
