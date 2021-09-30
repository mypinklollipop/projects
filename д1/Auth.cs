using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Demo
{
    public partial class Auth : Form
    {
        int tries;
        DateTime start;
        string[] users = {
            "user", "123",
            "user2", "456"
        };
        string[] admins =
        {
            "admin", "123"
        };
        string[] data;
        public Auth()
        {
            InitializeComponent();

            blockerr.Hide();
            _usrs_.users.Add(new User());
            _usrs_.users[_usrs_.users.Count - 1].setAll(DateTime.Now, "Alina", "Khis", "user1", "Doha", "1", "Admin");
            _usrs_.users.Add(new User());
            _usrs_.users[_usrs_.users.Count - 1].setAll(DateTime.Now, "Oksana", "Sav", "user2", "Doha", "2", "User");
            _usrs_.users.Add(new User());
            _usrs_.users[_usrs_.users.Count - 1].setAll(DateTime.Now, "Anastasia", "Mut", "user3", "Abu Dhabi", "3", "User");
            _usrs_.users[_usrs_.users.Count - 1].Block = true;
        }

        private void login_Click(object sender, EventArgs e)
        {
            void check()
            {
                if (tries == 3)
                {
                    Bloker.Enabled = true;
                    start = DateTime.Now;
                    tries++;
                }
                else if (tries > 3)
                {
                    /*do nothing*/
                } 
                else {
                    
                    for(int i = 0;i <= _usrs_.users.Count;)
                    {
                        if (i == _usrs_.users.Count)
                        {
                            loginerror.Show();
                            tries++;
                            break;
                        }
                        else if (_usrs_.users[i].Email == usernametb.Text)
                        {
                            blockerr.Hide();
                            loginerror.Hide();
                            if (_usrs_.users[i].Password == Passwordtb.Text)
                            {
                                if (_usrs_.users[i].Block == false)
                                {
                                    paserror.Hide();
                                    if (_usrs_.users[i].Role == "Admin")
                                    {
                                        // зайти как админ
                                        AdminPanel page2 = new AdminPanel(this);
                                        CurrentUser.Email = _usrs_.users[i].Email;
                                        CurrentUser.Fname = _usrs_.users[i].Fname;
                                        CurrentUser.Index = i;

                                        // add data to regedit
                                        Reg.keyKeep(_usrs_.users[i].Email, _usrs_.users[i].Password);

                                        page2.Show();
                                        this.Hide();
                                        break;
                                    }
                                    else
                                    {
                                        // зайти как простой пользователь
                                        CurrentUser.Email = _usrs_.users[i].Email;
                                        CurrentUser.Fname = _usrs_.users[i].Fname;
                                        CurrentUser.Index = i;
                                        UserPanel page2 = new UserPanel(this);

                                        // add data to regedit
                                        Reg.keyKeep(_usrs_.users[i].Email, _usrs_.users[i].Password);

                                        page2.Show();
                                        this.Hide();
                                        break;
                                    }
                                } else // если пользователь заблокирован, выдать ошибку
                                {
                                    blockerr.Show();
                                    break;
                                }
                            } else
                            {
                                paserror.Show();
                                tries++;
                                i++;
                                break;
                            }
                        } else
                        {
                            i++;
                            continue;
                        }
                    }
                }
            }
            check();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            paserror.Hide();
            loginerror.Hide();
            blockerr.Hide();
            try
            {
                string[] data = Reg.keyRead();
                void check()
                {
                    for (int i = 0; i <= _usrs_.users.Count;)
                    {
                        if (_usrs_.users[i].Email == data[0])
                        {
                            if (_usrs_.users[i].Password == data[1])
                            {
                                if (_usrs_.users[i].Block == false)
                                {
                                    usernametb.Text = data[0];
                                    Passwordtb.Text = data[1];
                                    break;
                                }
                                else // если пользователь заблокирован, выдать ошибку
                                {
                                    blockerr.Show();
                                    break;
                                }
                            }
                            else
                            {
                                i++;
                                break;
                            }
                        }
                        else
                        {
                            i++;
                            continue;
                        }
                    }
                }
                check();

            } catch { }
            tries = 1;
        }

        private void Bloker_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan interval = now - start;
            timer.Text = "Too much tries: 3. Wait " + (10 - interval.Seconds).ToString() + " seconds";
            if (interval.Seconds == 10)
            {
                tries = 1;
                Bloker.Enabled = false;
                timer.Text = "";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
