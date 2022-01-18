using System;
using System.Collections.Generic;


namespace Bank
{
    public class BankManagement
    {
        private List<Account> accounts;
        public BankManagement()
        {
            accounts = new List<Account>();
        }

        public void Run()
        {
            while (true)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if (choice == 0) break;
            }
        }

        private void PrintMenu()
        {
            System.Console.WriteLine("Bank Management Prorgram");
            System.Console.WriteLine("1. Add New Account");
            System.Console.WriteLine("2. Show Account List");
            System.Console.WriteLine("3. Withdraw");
            System.Console.WriteLine("4. Deposit");
            System.Console.WriteLine("0. Exit Program");
        }

        private int GetChoice()
        {
            System.Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        private void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddAccount(); break;
                case 2: ShowAccount(); break;
                case 3: Withdraw(); break;
                case 4: Deposit(); break;
                case 0: break;
            }
        }

        private void AddAccount()
        {
            Console.Clear();
            System.Console.WriteLine("Add new account to the bank!");
            System.Console.Write("Enter account username: ");
            string username = Console.ReadLine();
            System.Console.Write("Enter account's pin: ");
            int pin = Convert.ToInt32(Console.ReadLine());

            Account a = new Account(username, pin);
            accounts.Add(a);
            Console.Clear();
            System.Console.WriteLine("Account added successfully!");
        }

        private void ShowAccount()
        {
            Console.Clear();
            foreach (Account a in accounts)
            {
                a.ShowAccountInfo();
            }
        }

        private void Withdraw()
        {
            Console.Clear();
            System.Console.WriteLine("Withdraw from acount");
            System.Console.Write("Enter username: ");
            string username = Console.ReadLine();
            System.Console.Write("Enter pin: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            foreach (Account a in accounts)
            {
                if (a.Username.Equals(username) && a.Pin == pin)
                {
                    Console.Clear();
                    found = true;
                    a.ShowAccountInfo();
                    System.Console.Write("Enter the amount you want to withdraw: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    a.Withdraw(amount);
                    break;
                }
            }
            if (!found) System.Console.WriteLine("No account was found!");
        }

        private void Deposit()
        {
            Console.Clear();
            System.Console.WriteLine("Deposit to account");
            System.Console.Write("Enter username: ");
            string username = Console.ReadLine();
            System.Console.Write("Enter pin: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            foreach (Account a in accounts)
            {
                if (a.Username.Equals(username) && a.Pin == pin)
                {
                    Console.Clear();
                    found = true;
                    a.ShowAccountInfo();
                    System.Console.Write("Enter the amount you want to deposit: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    a.Deposit(amount);
                    break;
                }
            }
            if (!found) System.Console.WriteLine("No account was found!");
        }
    }
}
