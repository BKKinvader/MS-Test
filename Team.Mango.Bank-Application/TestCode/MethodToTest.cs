using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application.TestCode
{
    public class MethodToTest
    {
        //Test 1 Created Users
        public List<User> RunBank()
        {
            //Making a list of Users from User
            List<User> Users = new List<User>();

            //Create Users with empty account
            User Admin = new User("admin", "admin", "Tony", "Stark", "2129704133", new List<BankAccount>(), true);
            User User1 = new User("Tim", "1111", "Tim", "Nilsson", "0709496224", new List<BankAccount>(), false);
            User User2 = new User("Elin", "2222", "Elin", "Linderholm", "0708687334", new List<BankAccount>(), false);
            User User3 = new User("Dennis", "3333", "Dennis", "Ekner", "070427245", new List<BankAccount>(), false);
            User User4 = new User("Anton", "4444", "Anton", "Johansson", "0708687334", new List<BankAccount>(), false);


            //Add All User
            Users.Add(Admin);
            Users.Add(User1);
            Users.Add(User2);
            Users.Add(User3);
            Users.Add(User4);


            return Users;
        }


        //Test 2 LogIn
        public bool LoginGranted = false;
        public int Attempt = 2;

        public bool UserLogin(List<User> Users, string username, string password)
        {
            bool userFound = false;

            while (!LoginGranted && Attempt > 0)
            {
                //Check if username and password is matching with List<User> named Users
                foreach (var user in Users)
                {
                    if (username == user.Username && password == user.Password)
                    {
                        userFound = true;

                        // Checking if the user that logged in have access to admin ability
                        if (user.AdminCheck)
                        {
                            //Admin
                            LoginGranted = true;
                            Console.WriteLine("IS ADMIN");
                        }
                        else
                        {
                            //Standard user
                            LoginGranted = false;
                            Console.WriteLine("IS NOT ADMIN");
                        }

                        return LoginGranted; // if a user is found, exit the method with the result
                    }
                }

                if (!userFound)
                {
                    Console.WriteLine("Invalid Username or Password! you have " + Attempt + " attempts left");
                    Attempt--;
                }
            }

            if (Attempt == 0)
            {
                Console.WriteLine("You have tried too many times....");
            }

            return LoginGranted;
        }


        //Test 3
        public static double UpdateCurrentcyRate(CurrencyRates CurrRate)
        {
            Console.Clear();
            double minValue = 9.5;
            Random R = new Random();
            double newRate = R.NextDouble();
            CurrRate._currencyRate = newRate + minValue;

            string currUp = "New USD rate is  ";
            string goback = "Press enter to go back";
            Console.SetCursorPosition((Console.WindowWidth - currUp.Length) / 2, Console.CursorTop);
            Console.WriteLine(currUp + Math.Round(CurrRate._currencyRate, 2));
            Console.SetCursorPosition((Console.WindowWidth - goback.Length) / 2, Console.CursorTop);
            Console.WriteLine(goback);
            Console.ReadKey();

            return CurrRate._currencyRate;
        }


    }
}
