using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Факультет_Предмет : Form
    {



        public Факультет_Предмет()
        {
            InitializeComponent();

            panel1.Show();
            panel2.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Студент f2 = new Студент();

            f2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Успеваемость f3 = new Успеваемость();

            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.факультетTableAdapter.Fill(this._319_6_Хисамутдинова_АлинаDataSet3.Факультет);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.предметTableAdapter.Fill(this._319_6_Хисамутдинова_АлинаDataSet4.Предмет);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Специальность f4 = new Специальность();

            f4.Show();
            this.Hide();
        }

        private void Факультет_Предмет_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_319_6_Хисамутдинова_АлинаDataSet3.Факультет". При необходимости она может быть перемещена или удалена.
            this.факультетTableAdapter.Fill(this._319_6_Хисамутдинова_АлинаDataSet3.Факультет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_319_6_Хисамутдинова_АлинаDataSet4.Предмет". При необходимости она может быть перемещена или удалена.
            this.предметTableAdapter.Fill(this._319_6_Хисамутдинова_АлинаDataSet4.Предмет);
            

        }

        private void факультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }

        private void предметToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
