using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class Voting
    {
        private string title;
        private List<Candidate> candidats;
        public Voting(string title, List<Candidate> candidats)
        {
            this.title = title;
            List<Candidate> Candidate = candidats;
        }
    }
}