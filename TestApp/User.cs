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
        public bool Enter()
        {
            Console.WriteLine("Введите свой логин");
            string l = Console.ReadLine();
            Console.WriteLine("\nВведите свой пароль");
            string p = Console.ReadLine();
            if (login == l && password == p)
            {
                return true;
            }
            else
            {
                throw new Exception("У вас что-то не так");
            }
        }
        public string GetName()
        {
            return name;
        }
    }
}