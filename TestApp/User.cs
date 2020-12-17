using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class User
    {
        private string name;
        private string login;
        private string password;
        public User(string Name, string Login, string Password)
        {
            name = Name;
            login = Login;
            password = Password;
        }
        public bool Enter(string _login, string _password)
        {
            if (login == _login && password == _password)
            {
                return true;
            }
            else
            {
                throw new NullReferenceException("У вас что-то не так");
            }
        }
        public string GetName()
        {
            return name;
        }
    }
}