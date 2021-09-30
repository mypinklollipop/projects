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
    public partial class Специальность : Form
    {

        public Специальность()
        {
            InitializeComponent();

        }

        private void Специальность_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_319_6_Хисамутдинова_АлинаDataSet2.Специальность". При необходимости она может быть перемещена или удалена.
            this.специальностьTableAdapter.Fill(this._319_6_Хисамутдинова_АлинаDataSet2.Специальность);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.специальностьTableAdapter.Fill(this._319_6_Хисамутдинова_АлинаDataSet2.Специальность);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Факультет_Предмет f1 = new Факультет_Предмет();
            f1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Успеваемость f1 = new Успеваемость();
            f1.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Студент f1 = new Студент();
            f1.Show();
            this.Hide();

        }

        private void Специальность_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
