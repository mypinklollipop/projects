using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Demo
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());
        }
    }

    // Класс для создания профиля пользователя
    public class User
    {
        DateTime birthday;
        string fname;
        string lname;
        string email;
        string office;
        string password;
        string role;
        Boolean block = false;

        public List<TimeSpan> timeSpent = new List<TimeSpan>();
        public List<DateTime> Login = new List<DateTime>();
        public List<DateTime> Exit = new List<DateTime>();

        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Office
        {
            get
            {
                return office;
            }
            set
            {
                office = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        public Boolean Block
        {
            get
            {
                return block;
            }
            set
            {
                block = value;
            }
        }

        // метод быстрой подстановки
        public void setAll (DateTime _birthday, string _fname, string _lname, string _email, string _office, string _password, string _role)
        {
            birthday = _birthday;
            fname = _fname;
            lname = _lname;
            email = _email;
            office = _office;
            password = _password;
            role = _role;
        }
        public int ageCalc(DateTime now)
        {
            int age = now.Year - birthday.Year;
            if (now.Month < birthday.Month || (now.Month == birthday.Month && now.Day < birthday.Day))
            {
                age--;
            }
            return age;
        }
    }
    // класс для глобализации списка всех пользователей
    static class _usrs_
    {
        public static List<User> users = new List<User>();
    }

    static class CurrentUser
    {
        static string fname;
        static string email;
        static TimeSpan timeSpent;
        static DateTime timelogin;
        static DateTime timeExit;
        static int index;

        static public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        static public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        static public TimeSpan TimeSpent
        {
            get
            {
                return timeSpent;
            }
            set
            {
                timeSpent = value;
            }
        }
        static public DateTime TimeLogin
        {
            get
            {
                return timelogin;
            }
            set
            {
                timelogin = value;
            }
        }
        static public DateTime TimeExit
        {
            get
            {
                return timeExit;
            }
            set
            {
                timeExit = value;
            }
        }
        static public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
    }

    public class Reg
    {
        // "Фиксируем директорию, в которой будут действия с ключами"
        static RegistryKey rk = Registry.CurrentUser;

        // сохранить ключик (сохранение логина и пароля от сервиса)
        public static void keyKeep(string log, string pas)
        {
            // Создать папку в regedit в папке HKEY_CURRENT_USER
            RegistryKey AMONIC = rk.CreateSubKey("AMONIC");
            // Назвать ключ и дать ему значение
            AMONIC.SetValue("login", log);
            AMONIC.SetValue("password", pas);
            // Остановить поток
            AMONIC.Close();
        }
        public static string[] keyRead()
        {
            // Костыль
            // Пусть массив будет пустым, если ничего не получится
            string[] data = {"", ""};
            try
            {
                RegistryKey AMONIC = rk.CreateSubKey("AMONIC");
                // Получить значения ключей
                string l = AMONIC.GetValue("login").ToString();
                string p = AMONIC.GetValue("password").ToString();

                AMONIC.Close();

                // Записать в массив
                data[0] = l;
                data[1] = p;
            }
            // В любом случае вернуть массив, чтобы не сломать функцию
            catch { }
            return data;
        }
        public static void delKey()
        {
            RegistryKey AMONIC = rk.CreateSubKey("AMONIC");
            // удалить ключи
            AMONIC.DeleteValue("login");
            AMONIC.DeleteValue("password");
            AMONIC.Close();
        }
    }
}
