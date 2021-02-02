using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    public class User
    {
        private string name;
        private string login;
        private string password;

        public User(string name, string login, string password)
        {
            this.name = name;
            this.login = login;
            this.password = password;
        }

        public bool Enter(string login, string password)
        {
            if (this.login == login && this.password == password)
                return true;

            return false;
        }

        public string GetName()
        {
            return name;
        }
    }
}