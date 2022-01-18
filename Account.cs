namespace Bank
{
    public class Account
    {
        private int id;
        private string username = null!;
        private int pin;
        private double balance;
        private static int count = 0;
        public int Count
        {
            get { return count; }
        }

        public int Id
        {
            get { return id; }
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (value.Equals(null))
                {
                    username = "Username is not set!";
                }
                else
                {
                    username = value;
                }
            }
        }

        public int Pin
        {
            get { return pin; }
            set
            {
                if (pin < 0)
                {
                    pin = 0;
                }
                else
                {
                    pin = value;
                }
            }
        }

        public double Balance
        {
            get { return balance; }
        }

        public Account()
        {
            Username = "Username is not set!";
            Pin = 0;
            balance = 0;
            id = ++count;
        }

        public Account(string username, int pin)
        {
            Username = username;
            Pin = pin;
            balance = 0;
            id = ++count;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                System.Console.WriteLine("Deposit to account successully! Account Balance: " + Balance);
            }
            else
            {
                System.Console.WriteLine("Failed to deposit to the balance! Account Balace: " + Balance);

            }
        }

        public void Withdraw(double amount)
        {
            if (amount < balance && amount > 0)
            {
                balance -= amount;
                System.Console.WriteLine("Withdrawn from account successully! Account Balance: " + Balance);
            }
            else
            {
                System.Console.WriteLine("Failed to withdraw from the balance! Account Balace: " + Balance);
            }
        }

        public void ShowAccountInfo()
        {
            System.Console.WriteLine("----------Account Information----------");
            System.Console.WriteLine("User ID: " + Id);
            System.Console.WriteLine("Username: " + Username);
            System.Console.WriteLine("Pin number: " + Pin);
            System.Console.WriteLine("Balance: " + Balance);
            System.Console.WriteLine("---------------------------------------");
        }
    }
}