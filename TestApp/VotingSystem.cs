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
            Menu();

            Console.ReadLine();
        }

        private static User findUser(string login, string password)
        {
            return users.Find(currentUser => currentUser.Enter(login, password));
        }

        private static void Menu()
        {
            Console.WriteLine("1.Вход\n2.Регистрация\n3.Голосование\n4.Результаты\n5.Выход");
            int n = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (n)
                {
                    case 1:
                        Enter();
                        Menu();
                        break;
                    case 2:
                        Registration();
                        Menu();
                        break;
                    case 3:
                        ElectorVote();
                        Menu();
                        break;
                    case 4:
                        getResults();
                        Menu();
                        break;
                    case 5:
                        Exit();
                        break;
                }

            } while (n != 5);
        }

        private static void Enter()
        {
            while (currentUser == null)
            {
                Console.WriteLine("Введите ваш логин");
                string login = Console.ReadLine();

                Console.WriteLine("Введите ваш пароль");
                string password = Console.ReadLine();

                currentUser = findUser(login, password);

                if (currentUser != null)
                {
                    Console.WriteLine(currentUser.GetName());
                    Console.WriteLine("Вы ввошли в аккаунт. Можете голосовать");
                }
                else
                {
                    Console.WriteLine("Неправильный логин или пароль");
                }
            }
        }

        private static void Registration()
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите ваш логин");
            string login = Console.ReadLine();

            Console.WriteLine("Введите ваш пароль");
            string password = Console.ReadLine();

            users.Add(new Elector(name, login, password));
        }

        private static void ElectorVote()
        {
            if (currentUser.Enter())
            {
                string candidateName = Console.ReadLine();
                switch (candidateName)
                {
                    case "Donald Johnson":
                        AddVoice();
                        break;
                    case "Jonny Davis":
                        AddVoice();
                        break;
                    case "Harry Wilson":
                        AddVoice();
                        break;
                }
            }
        }

        private static List<Candidate> getResults()
        {
            List<Candidate> candidates = new List<Candidate>();

            candidates.Add(new Candidate("Donald Johnson"));
            candidates.Add(new Candidate("Jonny Davis"));
            candidates.Add(new Candidate("Harry Wilson"));

            int index = 0;

            foreach (Candidate c in candidates)
            {
                index++;
                Console.WriteLine(index + ". " + c.GetName());
                Console.WriteLine(c.getVoices());
            }

            return candidates;
        }

        private static void Exit()
        {
            string stringInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(stringInput))
            {
                Console.WriteLine("!!!!!");
                return;
            }
        }
    }
}