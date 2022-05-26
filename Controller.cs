using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervace
{
    internal class Controller
    {
        private string Username = String.Empty;
        private bool isAdmin = false;

        private static DBController _Conn;
        public static DBController Conn
        {
            get => _Conn;
            set => _Conn = value;
        }

        private Controller(DBController dbController)
        {
            Conn = dbController;
        }

        public static Controller? GetInstance()
        {
            DBController dbc;
            try
            {
                dbc = new();
            } catch (Exception)
            {
                MessageBox.Show("Database connection failed");
                return null;
            }
            return new Controller(dbc);
        }

        public void Start()
        {
            if (!StartLogin())
            {
                return;
            }
            isAdmin = Conn.IsAdmin(Username).Result;
            StartUI();
        }

        private bool StartLogin()
        {
            Login loginDialog = new();
            if (loginDialog.ShowDialog() == DialogResult.OK)
            {
                Username = loginDialog.Username;
                return true;
            }
            return false;
        }

        private void StartUI()
        {
            MainForm? mf;
            if ((mf = MainForm.GetInstance(Username, isAdmin, Conn)) != null) {
                Application.Run(mf);
            }
        }

    }
}
