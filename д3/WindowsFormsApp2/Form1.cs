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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string connectionString;
        string sql;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        DataSet ds;
        DataTable dt;


        public Form1()
        {
            InitializeComponent();
            

        }

        private void MethodOne()
        {
            connectionString = (@"Data Source=." + textBox1.Text + ";Initial Catalog=" + textBox2.Text + ";Integrated Security=True");
            sql = ("SELECT * FROM " + textBox3.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
                dt = ds.Tables[0];
            }
        }

        private void MethodTwo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(ds);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MethodOne();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butsave_Click(object sender, EventArgs e)
        {
            MethodTwo();
            MethodOne();

        }

        private void butadd_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.NewRow();
            dt.Rows.Add(newRow);
        }

        private void butdel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            MethodTwo();
        }
    }
}