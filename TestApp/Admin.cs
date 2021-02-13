using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Admin : User
    {
        private string login;
        private string password;
        private bool admin;

        public Admin(string name, string login, string password)
            :base (name, login, password)
        {
            this.login = login;
            this.password = password;
            admin = false;
        }

        public bool AdminEnter(string login, string password)
        {
            if (this.login == login && this.password == password)
                return true;

            return false;
        }

        public bool IsAdmin()
        {
            return admin = true;
        }
    }
}