using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class Elector : User
    {
        private bool voted;
        public Elector(bool Voted, string name, string login, string password)
            : base(name, login, password)
        {
            voted = Voted;
        }
        public bool IsVoted()
        {
            return voted = false;
        }
        public void Vote()
        {

        }
    }
}