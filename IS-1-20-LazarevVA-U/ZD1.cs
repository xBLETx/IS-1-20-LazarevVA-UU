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
    public partial class ZD1 : Form
    {
        public ZD1()
        {
            InitializeComponent();
        }
        public abstract class Components<T>
        {
            public T articul;
            public double price;
            public string datatime;

            public Components(T articul, double price, string datatime)
            {
                this.articul = articul;
                this.price = price;
                this.datatime = datatime;

            }

            public void Display()
            {
                MessageBox.Show($"Артикул: {articul} \n Цена: {price} \n Год Выпуска: {datatime}");
            }
        }

        public class HDD<T> : Components<T>
        {
            int spidObr { get; set; }
            public string interfaces { get; set; }
            public int Ob { get; set; }

            public HDD(T articul, double price, string datatime,int spidObr, string interfaces, int Ob) : base(articul, price, datatime)
            {
                this.spidObr = spidObr;
                this.interfaces = interfaces;
                this.Ob = Ob;
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
