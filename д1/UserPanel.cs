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
    public partial class UserPanel : Form
    {
        Auth page1;
        DateTime start;
        int i = CurrentUser.Index; // индекс существуующего пользователя

        public UserPanel(Auth _page1)
        {
            InitializeComponent();
            page1 = _page1;
        }
        public void Page2_Closing(object sender, EventArgs e) //удалить
        {
            page1.Show();
        }

        private void UP1_Load(object sender, EventArgs e)
        {
            crashes.Text = "0";
            // приветствие
            Into.Text = "Hi " + CurrentUser.Fname + ", Welcome to AMONIC Airlines.";
            
            // подгрузка таблицы
            OnlyOneUserData.Rows.Clear();

           for (int j = 0; j < _usrs_.users[i].Login.Count; j++)
            {
                OnlyOneUserData.Rows.Add(
                 _usrs_.users[i].Login[j].ToString("d"),
                 _usrs_.users[i].Login[j].ToUniversalTime().ToString("t"),
                 _usrs_.users[i].Exit[j].ToUniversalTime().ToString("t"),
                 _usrs_.users[i].timeSpent[j].Minutes + ":" + _usrs_.users[i].timeSpent[j].Seconds, ""
                 );
            }

            start = DateTime.Now;
            CurrentUser.TimeLogin = start;
            timer.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            page1.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // вычисление проведенного времени в приложении
            DateTime now = DateTime.Now;
            CurrentUser.TimeSpent = now - start;
            TimeOnSys.Text = "Time spent on system: " + CurrentUser.TimeSpent.Minutes + ":" + CurrentUser.TimeSpent.Seconds;
        }

        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
             CurrentUser.TimeExit = DateTime.Now;
            _usrs_.users[i].Login.Add(CurrentUser.TimeLogin);
            _usrs_.users[i].timeSpent.Add(CurrentUser.TimeSpent);
            _usrs_.users[i].Exit.Add(CurrentUser.TimeExit);
        }
    }
}
