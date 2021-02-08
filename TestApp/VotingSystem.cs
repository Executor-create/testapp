using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    class VotingSystem
    {
        private static List<User> users = new List<User>();
        private static List<Candidate> candidates = new List<Candidate>();
        private static User currentUser;

        static void Main(string[] args)
        {
            Menu();

            Console.ReadLine();
        }

        private static User findUser(string login, string password)
        {
            return users.Find(currentUser => currentUser.Enter(login, password));
        }

        private static void Menu()
        {
            int menuIndex = 0;
            do
            {
                Console.WriteLine("1.Login\n2.Regisration\n3.Vote\n4.Results\n5.Add Candidate\n6.Exit");

                var answer = Console.ReadLine();

                try
                {
                    menuIndex = Convert.ToInt32(answer);
                }
                catch
                {
                    Console.WriteLine("Enter correct value");
                }

                switch (menuIndex)
                {
                    case 1:
                        LogIn();
                        break;
                    case 2:
                        Registration();
                        break;
                    case 3:
                        ElectorVote();
                        break;
                    case 4:
                        getResults();
                        break;
                    case 5:
                        AddCandidate();
                        break;
                    case 6:
                        Exit();
                        break;
                }

            } while (menuIndex != 6);
        }

        private static void LogIn()
        {
            while (currentUser == null)
            {
                Console.WriteLine("Enter your login");
                string login = Console.ReadLine();

                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();

                currentUser = findUser(login, password);

                if (currentUser != null)
                {
                    Console.WriteLine(currentUser.GetName());
                    Console.WriteLine("You are logged into your account. You can vote");
                }
                else
                {
                    Console.WriteLine("Incorrect login or password");

                }
            }
        }

        private static void Registration()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your login");
            string login = Console.ReadLine();

            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            users.Add(new Elector(name, login, password));
        }

        private static void AddCandidate()
        {
            Console.WriteLine("Enter candidate name");
            string name = Console.ReadLine();

            candidates.Add(new Candidate(name));
        }

        private static void ElectorVote()
        {
            int index = 1;

            foreach (Candidate c in candidates)
            {
                Console.WriteLine(index + ". " + c.GetName());
                index++;
            }

            if (currentUser != null)
            {
                int candidateIndex = Convert.ToInt32(Console.ReadLine());

                candidates[candidateIndex - 1].AddVoice();
            }
            else
            {
                Console.WriteLine("You are not logged into your account");
                Menu();
            }
        }

        private static List<Candidate> getResults()
        {
            int index = 1;

            foreach (Candidate c in candidates)
            {
                Console.WriteLine(index + ". " + c.GetName() + " " + c.getVoices());
                index++;
            }

            return candidates;
        }

        private static void Exit()
        {
            string stringInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(stringInput))
            {
                Console.WriteLine("Exit");
                return;
            }
        }
    }
}