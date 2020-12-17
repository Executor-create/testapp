using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    class VotingSystem
    {
        private static List<User> users;
        private Voting currentVoting;
        private static User currentUser;
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User("Jack Doglas", "Jacki21", "qwets2"));
            users.Add(new User("Bob Robinson", "Bobik", "bwergr2"));
            users.Add(new User("Elvis Cooper", "Elden", "2gdqw"));
            users.Add(new User("Mike Clark", "Hadler", "irhn2"));
            foreach (User u in users)
            {
                Console.WriteLine(u.GetName());
                u.Enter();
                
            }

            Console.WriteLine("----------------");

            List<Candidate> candidates = new List<Candidate>();
            candidates.Add(new Candidate("1.Donald Johnson"));
            candidates.Add(new Candidate("2.Jonny Davis"));
            candidates.Add(new Candidate("3.Harry Wilson"));
            foreach(Candidate c in candidates)
            {
                Console.WriteLine(c.GetName());
                c.getVoices();
            }
          
            Console.ReadKey();
        }
        private static void findUser(User login, User password)
        {
            users.Find(currentUser => (currentUser == login) && (currentUser == password));
        }
        private static List<Candidate> getResults()
        {
            List<Candidate> candidates = new List<Candidate>();
            return candidates;
        }
    }
}