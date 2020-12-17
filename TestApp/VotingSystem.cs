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
            users.Add(new User("Tom McConor", "qwrqr", "werwer"));
            users.Add(new User("Jack Doglas", "Jacki21", "qwets2"));
            users.Add(new User("Bob Robinson", "Bobik", "bwergr2"));
            users.Add(new User("Elvis Cooper", "Elden", "234gdqw"));
            users.Add(new User("Mike Clark", "Hadler", "irhn2"));
            foreach (User u in users)
            {
                Console.WriteLine(u.GetName());
                u.Enter();

            }
        }
        private static void addUser()
        {
            
        }
        private static void findUser(User login, User password)
        {
            users.Find(currentUser => (currentUser == login) && (currentUser == password));
        }
        private List<Candidate> getResults()
        {
            List<Candidate> candidates = new List<Candidate>();
            candidates.Add(new Candidate("Donald Johnson"));
            candidates.Add(new Candidate("Jonny Davis"));
            candidates.Add(new Candidate("Harry Wilson"));
            return candidates;
        }
    }
}