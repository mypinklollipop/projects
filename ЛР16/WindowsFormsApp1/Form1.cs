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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @" Data Source= ADCLG1; Initial catalog=319_6_Хисамутдинова_Алина; Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);
            string ComDel = "declare @id int select @id = max(id) from Библиотека set @id += 1 insert into Библиотека values(@id, @name , @author, @pages, @year) ";
            SqlCommand cmd1 = new SqlCommand(ComDel, MyConnection);
            SqlParameter pr1 = new SqlParameter("@name", textBoxADDNAME.Text);
            SqlParameter pr2 = new SqlParameter("@author", textBoxADDAUTHOR.Text);
            SqlParameter pr3 = new SqlParameter("@pages", Convert.ToInt32(textBoxADDPAGES.Text));
            SqlParameter pr4 = new SqlParameter("@year", Convert.ToInt32(textBoxADDYEAR.Text));
            cmd1.Parameters.Add(pr1);
            cmd1.Parameters.Add(pr2);
            cmd1.Parameters.Add(pr3);
            cmd1.Parameters.Add(pr4);
            MyConnection.Open();
            cmd1.ExecuteNonQuery();
            MyConnection.Close();
            this.библиотекаTableAdapter.Fill(this._319_6_Хисамутдинова_АлинаDataSet.Библиотека);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_319_6_Хисамутдинова_АлинаDataSet.Библиотека". При необходимости она может быть перемещена или удалена.
            this.библиотекаTableAdapter.Fill(this._319_6_Хисамутдинова_АлинаDataSet.Библиотека);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @" Data Source= ADCLG1; Initial catalog=319_6_Хисамутдинова_Алина; Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);
            string ComDel = "Delete from Библиотека where id = @id";
            SqlCommand cmd1 = new SqlCommand (ComDel, MyConnection );
            SqlParameter pr1 = new SqlParameter ("@id", textBoxDELETEID.Text );
            cmd1.Parameters.Add(pr1);
            MyConnection.Open();
            cmd1.ExecuteNonQuery();
            MyConnection.Close();
            this.библиотекаTableAdapter.Fill(this._319_6_Хисамутдинова_АлинаDataSet.Библиотека);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @" Data Source= ADCLG1; Initial catalog=319_6_Хисамутдинова_Алина; Integrated Security=True";
            SqlConnection MyConnection = new SqlConnection(connectionString);
            string ComDel = "update Библиотека set Название = @name , Автор = @author, [Количество страниц] = @pages, Год = @year where id = @id ";
            SqlCommand cmd1 = new SqlCommand(ComDel, MyConnection);
            SqlParameter pr1 = new SqlParameter("@name", textBoxUPDATENAME.Text);
            SqlParameter pr2 = new SqlParameter("@author", textBoxUPDATEAUTHOR.Text);
            SqlParameter pr3 = new SqlParameter("@pages", Convert.ToInt32(textBoxUPDATEPAGES.Text));
            SqlParameter pr4 = new SqlParameter("@year", Convert.ToInt32(textBoxUPDATEYEAR.Text));
            SqlParameter pr5 = new SqlParameter("@id", textBoxUPDATEID.Text);
            cmd1.Parameters.Add(pr1);
            cmd1.Parameters.Add(pr2);
            cmd1.Parameters.Add(pr3);
            cmd1.Parameters.Add(pr4);
            cmd1.Parameters.Add(pr5);
            MyConnection.Open();
            cmd1.ExecuteNonQuery();
            MyConnection.Close();
            this.библиотекаTableAdapter.Fill(this._319_6_Хисамутдинова_АлинаDataSet.Библиотека);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
