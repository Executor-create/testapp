using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class Candidate
    {
        private string name;
        private static int voices = 0;

        public Candidate(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public static void AddVoice()
        {
            voices++;
        }
        public int getVoices()
        {
            return voices;
        }
    }
}