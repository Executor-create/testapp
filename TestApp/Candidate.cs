using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class Candidate
    {
        private string name;
        private int voices = 0;
        public Candidate(string Name)
        {
            name = Name;
        }
        public string GetName()
        {
            return name;
        }
        public void AddVoice()
        {
            voices++;
        }
        public int getVoices()
        {
            return voices;
        }
    }
}