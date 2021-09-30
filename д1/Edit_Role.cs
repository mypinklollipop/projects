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
    public partial class Edit_Role : Form
    {
        AdminPanel panel;
        string _fname, _lname, _email, _oldemail, _role;
        int _row;

        private void cencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            if (adminRadio.Checked == true)
            {
                _role = "Admin";
            } else
            {
                _role = "User";
            }
            _email = emailTB.Text;
            _fname = fnameTB.Text;
            _lname = lnameTB.Text;
            panel.setData(_fname, _lname, _email, _oldemail, _role, _row);
            this.Close();
        }

        private void Edit_Role_Load(object sender, EventArgs e)
        {
            emailTB.Text = _email;
            fnameTB.Text = _fname;
            lnameTB.Text = _lname;
            
            if (_role == "Admin")
            {
                adminRadio.Checked = true;
                _role = "Admin";
            } else
            {
                userRadio.Checked = true;
                _role = "User";
            }
        }

        public Edit_Role(AdminPanel _panel, string fname, string lname, string email, string role, int row)
        {
            InitializeComponent();
            panel = _panel;
            _fname = fname;
            _lname = lname;
            _email = email;
            _role = role;
            _row = row;
            _oldemail = email;
        }
    }
}
