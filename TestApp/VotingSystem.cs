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
        private static Admin admin = new Admin("admin", "admin", "123");

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
                Console.WriteLine("1.Login\n2.Regisration\n3.Vote\n4.Results\n5.Add Candidate\n6.Admin cabinet\n7.Exit");

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
                        AdminCabinet();
                        break;
                    case 7:
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

        private static void AdminCabinet()
        {
            Console.WriteLine("Enter your login");
            string login = Console.ReadLine();

            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            if (admin.AdminEnter(login, password))
            {
                Console.WriteLine("Welcome to admine cabinet");
                admin.TrueAdmin();
                Menu();
            }
            else
            {
                Console.WriteLine("Wrong login or password");
            }
        }

        private static void AddCandidate()
        {
            if (admin.IsAdmin() == true)
            {
                Console.WriteLine("Enter candidate name");
                string name = Console.ReadLine();

                candidates.Add(new Candidate(name));
            }
            else if (currentUser != admin && admin.IsAdmin() == false)
            {
                Console.WriteLine("You is not admin");
            }
        }

        private static void ElectorVote()
        {
            int index = 1;

            foreach (Candidate candidate in candidates)
            {
                Console.WriteLine(index + ". " + candidate.GetName());
                index++;
            }

            if (currentUser != null)
            {
                if (((Elector)currentUser).IsVoted() == false)
                {
                    int candidateIndex = Convert.ToInt32(Console.ReadLine());

                    candidates[candidateIndex - 1].AddVoice();
                    ((Elector)currentUser).Vote();
                }
                else
                {
                    Console.WriteLine("You have already voted");
                }
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

            var CandidateVoice = from c in candidates
                                 where c.getVoices() > 2
                                 select c;

            if (admin.IsAdmin() == true)
            {
                foreach (Candidate candidate in candidates)
                {
                    Console.WriteLine(index + ". " + candidate.GetName() + " " + candidate.getVoices());
                    index++;
                }

                foreach (var c in CandidateVoice)
                {
                    Console.WriteLine($"Most votes in {c.GetName()}" + " " + c.getVoices() + " .Hi won");
                }
            }
            else if (currentUser != admin)
            {
                Console.WriteLine("You is not admin");
                Menu();
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