using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Demo
{
    public partial class AdminPanel : Form
    {
        Auth page1;
        string fname, email, lname, office, role;
        DateTime start;
        int ind = CurrentUser.Index; // индекс существуующего пользователя
        public AdminPanel(Auth _page1)
        {
            InitializeComponent();
            page1 = _page1;
        }
        
        private void AP1_Load(object sender, EventArgs e)
        {
            officesCB.SelectedIndex = 0;
            start = DateTime.Now;
            CurrentUser.TimeLogin = start;
            timer.Enabled = true;
        }

        // выход по кнопке "Exit"
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reg.delKey();
            this.Close();
            page1.Show();
        }

        private void officesCB_SelectedValueChanged(object sender, EventArgs e)
        {
            AllUsersData.Rows.Clear();
            foreach (User user in _usrs_.users)
            {
                if (user.Office == officesCB.SelectedItem.ToString())
                {
                    AllUsersData.Rows.Add(user.Fname, user.Lname, user.ageCalc(DateTime.Now), user.Role, user.Email, user.Office);
                    int curRow = AllUsersData.Rows.Count - 2;
                    // перекрасить
                    if (user.Block == false) { AllUsersData.Rows[curRow].DefaultCellStyle.BackColor = Color.Green; ; }
                    else if (user.Block == true){ AllUsersData.Rows[curRow].DefaultCellStyle.BackColor = Color.Red; }
                }
                else if (officesCB.SelectedIndex == 0)
                {
                    AllUsersData.Rows.Add(user.Fname, user.Lname, user.ageCalc(DateTime.Now), user.Role, user.Email, user.Office);
                    int curRow = AllUsersData.Rows.Count - 2;
                    // перекрасить
                    if (user.Block == false) { AllUsersData.Rows[curRow].DefaultCellStyle.BackColor = Color.Green; ; }
                    else if (user.Block == true) { AllUsersData.Rows[curRow].DefaultCellStyle.BackColor = Color.Red; }
                }
            }
        }

        private void LoginDisOrEnab_Click(object sender, EventArgs e)
        {
            int curRow = AllUsersData.CurrentCell.RowIndex;
            email = AllUsersData[4, curRow].Value.ToString();
            foreach (User user in _usrs_.users)
            {
                if (user.Email == email)
                {
                    if (user.Block == false)
                    {
                        user.Block = true;
                        AllUsersData.Rows[curRow].DefaultCellStyle.BackColor = Color.Red;  
                    } else
                    {
                        user.Block = false;
                        AllUsersData.Rows[curRow].DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // вычисление проведенного времени в приложении
            DateTime now = DateTime.Now;
            CurrentUser.TimeSpent = now - start;
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            CurrentUser.TimeExit = DateTime.Now;
            _usrs_.users[ind].Login.Add(CurrentUser.TimeLogin);
            _usrs_.users[ind].timeSpent.Add(CurrentUser.TimeSpent);
            _usrs_.users[ind].Exit.Add(CurrentUser.TimeExit);
        }

        // Отрисовать окно "Add user" по кнопке
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_User adduser = new Add_User(this);
            adduser.ShowDialog();
        }
        
        // кнопка для изменения некоторых полей у выделенного пользователя
        private void changeRole(object sender, EventArgs e)
        {
            try
            { 
                int curRow = AllUsersData.CurrentCell.RowIndex;
                fname = AllUsersData[0, curRow].Value.ToString();
                lname = AllUsersData[1, curRow].Value.ToString();
                role = AllUsersData[3, curRow].Value.ToString();
                office = AllUsersData[5, curRow].Value.ToString();
                email = AllUsersData[4, curRow].Value.ToString();

                // передать данные выделенной строки в форму редактирования
                Edit_Role editRole = new Edit_Role(this, fname, lname, email, role, curRow);
                editRole.ShowDialog();
            }
            catch {}
        }

        /*
        *   getData setData - получение и установка данных из формы "add user" и "change role"
        *   из "add user"
        */
        public void getData(string _email, string _fname, string _lname, string _office, DateTime _birthday, string _password)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - _birthday.Year;
            if (now.Month < _birthday.Month || (now.Month == _birthday.Month && now.Day < _birthday.Day))
            {
                age--;
            }
            AllUsersData.Rows.Add(_fname, _lname, age, "User", _email, _office);
            int curRow = AllUsersData.Rows.Count - 2;
            // не чинить!!!
            if (_usrs_.users[_usrs_.users.Count - 1].Block == false) { AllUsersData.Rows[curRow].DefaultCellStyle.BackColor = Color.Red; }
            else if (_usrs_.users[_usrs_.users.Count - 1].Block == true) { AllUsersData.Rows[curRow].DefaultCellStyle.BackColor = Color.Green; }
            //
        }
        // из "change role"
        public void setData(string _fname, string _lname, string _email, string oldemail, string _role, int _row)
        {
            for (int i = 0; i < _usrs_.users.Count; i++)
            {
                if (_usrs_.users[i].Email == oldemail)
                {
                    // изменить данные в классе
                    _usrs_.users[i].Fname = _fname;
                    _usrs_.users[i].Email = _email;
                    _usrs_.users[i].Lname = _lname;
                    _usrs_.users[i].Role = _role;

                    // изменить в таблице
                    AllUsersData[ 0, _row].Value = _fname;
                    AllUsersData[1, _row].Value = _lname;
                    AllUsersData[3, _row].Value = _role;
                    AllUsersData[4,_row].Value = _email;
                    break;
                }
            } 
        }
    }
}
