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
            addUser();
        }
        private static void addUser()
        {
            List<User> users = new List<User>();
            users.Add(new User("Tom", "hawer52", "rgdqwer23"));
            users.Add(new User("Jack", "Jacki21", "qwets2"));
            users.Add(new User("Bob", "Bobik", "bwergr2"));
            users.Add(new User("Elvis", "Elden", "234gdqw"));
            users.Add(new User("Mike", "Hadler", "irhn2"));
            foreach (var u in users)
            {
                Console.WriteLine(u);
            }
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