using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    class VotingSystem
    {
        private static List<User> users = new List<User>();
        private Voting currentVoting;
        private static User currentUser;

        static void Main(string[] args)
        {
            //Initi users
            users.Add(new User("Jack Doglas", "Jacki21", "qwets2"));
            users.Add(new User("Bob Robinson", "Bobik", "bwergr2"));
            users.Add(new User("Elvis Cooper", "Elden", "2gdqw"));
            users.Add(new User("Mike Clark", "Hadler", "irhn2"));

            //Login as user
            while (currentUser == null)
            {
                Console.WriteLine("Please enter your login");
                string login = Console.ReadLine();

                Console.WriteLine("Please enter your password");
                string password = Console.ReadLine();

                currentUser = findUser(login, password);

                if (currentUser != null)
                {
                    Console.WriteLine(currentUser.GetName());
                }
                else
                {
                    Console.WriteLine("Неправильный логин или пароль");
                }
            }

            Console.WriteLine("----------------");

            List<Candidate> candidates = new List<Candidate>();

            candidates.Add(new Candidate("Donald Johnson"));
            candidates.Add(new Candidate("Jonny Davis"));
            candidates.Add(new Candidate("Harry Wilson"));

            var index = 0;

            foreach(Candidate c in candidates)
            {
                index++;
                Console.WriteLine(index + ". " + c.GetName());
                c.getVoices();
            }
          
            Console.ReadKey();
        }

        public static User findUser(string login, string password)
        {
            return users.Find(currentUser => currentUser.Enter(login, password));
        }

        private List<Candidate> getResults()
        {
            List<Candidate> candidates = new List<Candidate>();
            return candidates;
        }
    }
}