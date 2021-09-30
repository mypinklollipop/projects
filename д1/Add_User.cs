using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Add_User : Form
    {
        AdminPanel panel;
        public Add_User(AdminPanel _panel)
        {
            InitializeComponent();
            panel = _panel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname, email, lname, office, password;
            fname = fnameTB.Text;
            email = emailTB.Text;
            lname = lnameTB.Text;
            office = officesCB.SelectedItem.ToString();
            password = passwordTB.Text;

            if ((fname == "") || (email == "") || (lname == "") || (office == "") || (password == ""))
            {
                fillerror.Show();
            }
            else
            {
                fillerror.Hide();
                // переместить данные в админ-панель
                panel.getData(email, fname, lname, office, Birthday.Value, password);

                // создать новый экземпляр пользователя и поместить его в лист
                _usrs_.users.Add(new User());
                _usrs_.users[_usrs_.users.Count - 1]
                    .setAll(Birthday.Value, fname, lname, email, office, password, "User");
                this.Close();
            }
        }

        private void Add_User_Load(object sender, EventArgs e)
        {
            fillerror.Hide();
            officesCB.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
