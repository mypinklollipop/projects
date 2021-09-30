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
    public partial class Успеваемость : Form
    {


        public Успеваемость()
        {
            InitializeComponent();

        }

        private void Успеваемость_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_319_6_Хисамутдинова_АлинаDataSet1.Успеваемость". При необходимости она может быть перемещена или удалена.
            this.успеваемостьTableAdapter.Fill(this._319_6_Хисамутдинова_АлинаDataSet1.Успеваемость);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.успеваемостьTableAdapter.Fill(this._319_6_Хисамутдинова_АлинаDataSet1.Успеваемость);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Студент f1 = new Студент();
            f1.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Факультет_Предмет f1 = new Факультет_Предмет();
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Специальность f1 = new Специальность();
            f1.Show();
            this.Hide();
        }

        private void Успеваемость_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
