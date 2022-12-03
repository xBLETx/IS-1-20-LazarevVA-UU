﻿using System;
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
            public int price;
            public string datatime;

            public Components(T articul, int price, string datatime)
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

            public HDD(T articul, int price, string datatime,int spidObr, string interfaces, int Ob) : base(articul, price, datatime)
            {
                this.spidObr = spidObr;
                this.interfaces = interfaces;
                this.Ob = Ob;
            }
            public new void Display()
            {
                MessageBox.Show($"Артикул: {articul} \n Цена: {price} \n Год Выпуска: {datatime} \n Количество обротов: {spidObr} " +
                    $"\n Интерфейс:{interfaces} \n ОбЪём памяти: {Ob} ");
            }

        }
         public class GPU<T>: Components<T>
        {
            public int freq { get; set; }
            public string marker  { get; set; }
            public int mem { get; set; }

            public GPU(T articul, int price, string datatime, int freq, string marker, int mem): base(articul, price, datatime)
            {
                this.freq = freq;
                this.marker = marker;
                this.mem = mem;
            }
            public new void Display()
            {
                MessageBox.Show($"Артикул: {articul} \n Цена: {price} \n Год Выпуска: {datatime} \n Частота: {freq} \n Производитель: {marker} \n Объём памяти:{mem}");
            }
           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
                listBox1.Items.Clear();
            GPU<string> BLET = new GPU<string>((guna2TextBox9.Text), Convert.ToInt32(guna2TextBox1.Text), (guna2TextBox2.Text), Convert.ToInt32(guna2TextBox5.Text),
                (guna2TextBox6.Text), Convert.ToInt32(guna2TextBox8.Text));
                listBox1.Items.Add($" Цена:{guna2TextBox1.Text} Производитель:{guna2TextBox6.Text} Частота GPU:{guna2TextBox5.Text} Объём памяти:{guna2TextBox8.Text}" +
                    $"Дата выпуска: {guna2TextBox2.Text} Артикул:{guna2TextBox9.Text}");
            BLET.Display();
                
                
                
                

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            HDD<string> BLET = new HDD<string>((guna2TextBox9.Text), Convert.ToInt32(guna2TextBox1.Text), (guna2TextBox2.Text), Convert.ToInt32(guna2TextBox4.Text),
                (guna2TextBox3.Text), Convert.ToInt32(guna2TextBox7.Text));
            listBox1.Items.Add($" Цена:{guna2TextBox1.Text} Интрефейс:{guna2TextBox3.Text} Кол-воОборотов:{guna2TextBox4.Text} Объём памяти:{guna2TextBox7.Text}" +
                $"Дата выпуска: {guna2TextBox2.Text} Артикул:{guna2TextBox9.Text}");
            BLET.Display();
        }
    }
}
