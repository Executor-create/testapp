using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    public class Elector : User
    {
        private static bool voted;

        public Elector(string name, string login, string password)
            : base(name, login, password)
        {
        }

        public bool IsVoted()
        {
            return voted;
        }

        public static void Vote()
        {
            voted = true;
        }
    }
}