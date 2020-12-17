using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class Voting
    {
        private string title;
        private List<Candidate> candidats;
        public Voting(string Title, List<Candidate> candidats)
        {
            title = Title;
            List<Candidate> Candidate = candidats;
        }
    }
}