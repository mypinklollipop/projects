using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Из_9
{
    public partial class Подсчет_времени : Form
    {
        Form1 form1;
        int seconds=0;
        

        public Подсчет_времени(Form1 f1)
        {
            InitializeComponent();
            form1 = f1;
            
        }

        private void Подсчет_времени_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Подсчет_времени_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (form1.comboBox1.Text == "Новый год")
            {
                DateTime dt1 = new DateTime(2022, 1, 1);
                DateTime dt2 = DateTime.Now;
                TimeSpan interval = dt1 - dt2;
                label1.Text = "До праздника Новый год осталось: " + interval.Days + " дней " + interval.Hours + " часов " +
                interval.Minutes + " минут " + (interval.Seconds - seconds) + " секунд";
            }
            if (form1.comboBox1.Text == "Международный женский день")
            {
                DateTime dt1 = new DateTime(2022, 3, 8);
                DateTime dt2 = DateTime.Now;
                TimeSpan interval = dt1 - dt2;
                label1.Text = "До праздника Международный женский ден осталось: " + interval.Days + " дней " + interval.Hours + " часов " +
                interval.Minutes + " минут " + (interval.Seconds - seconds) + " секунд";
            }
            if (form1.comboBox1.Text == "День защитника Отечества")
            {
                DateTime dt1 = new DateTime(2022, 2, 23);
                DateTime dt2 = DateTime.Now;
                TimeSpan interval = dt1 - dt2;
                label1.Text = "До праздника День защитника Отечества осталось: " + interval.Days + " дней " + interval.Hours + " часов " +
                interval.Minutes + " минут " + (interval.Seconds - seconds) + " секунд";
            }
            if (form1.comboBox1.Text == "День народного единства")
            {
                DateTime dt1 = new DateTime(2021, 11, 4);
                DateTime dt2 = DateTime.Now;
                TimeSpan interval = dt1 - dt2;
                label1.Text = "До праздника День народного единства осталось: " + interval.Days + " дней " + interval.Hours + " часов " +
                interval.Minutes + " минут " + (interval.Seconds - seconds ) + " секунд";
            }
            if (form1.comboBox1.Text == "День победы")
            {
                DateTime dt1 = new DateTime(2021, 5, 9);
                DateTime dt2 = DateTime.Now;
                TimeSpan interval = dt1 - dt2;
                label1.Text = "До праздника День победы осталось: " + interval.Days + " дней " + interval.Hours + " часов " +
                interval.Minutes + " минут " + (interval.Seconds - seconds) + " секунд";
            }
        }
    }
    }
