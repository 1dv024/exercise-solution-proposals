using System;

namespace ConsolingBank
{
    /// <summary>
    /// Represents a simplified bank account.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// The interest rate.
        /// </summary>
        private const double Rate = 0.035;

        /// <summary>
        /// The amount of money of the current instance. 
        /// </summary>
        private double _balance;

        /// <summary>
        /// Initializes a new instance of the Account class.
        /// </summary>
        /// <param name="name">The name of the account holder.</param>
        /// <param name="accountNUmber">The number identifing the account.</param>
        /// <param name="balance">The balance of the account.</param>
        public Account(string name, int accountNUmber, double balance)
        {
            Name = name;
            AccountNumber = accountNUmber;
            Balance = balance;
        }

        /// <summary>
        /// The number identifing the account.
        /// </summary>
        public int AccountNumber { get; }

        /// <summary>
        /// Gets or sets the balance of the account.
        /// </summary>
        public double Balance
        {
            get { return _balance; }

            private set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException(
                        "The balance can not be set to an amount less than 0.");
                }
                _balance = value;
            }
        }

        /// <summary>
        /// The name of the account holder.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Deposits an amount of money in the account.
        /// </summary>
        /// <param name="amount">The amount of money to deposit.</param>
        /// <returns>The new balance of the account.</returns>
        public double Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new InvalidOperationException(
                    "The amount can not be less than 0.");
            }

            return Balance += amount;
        }

        /// <summary>
        /// Whithdraws money from the account and returning the new balance.
        /// </summary>
        /// <param name="amount">The amount of money to withdraw.</param>
        /// <param name="fee">The withdrawal fee.</param>
        /// <returns>The new balance of the account.</returns>
        public double Withdraw(double amount, double fee)
        {
            if (amount + fee < 0 ||
                amount + fee > _balance)
            {
                throw new InvalidOperationException(
                    "Manage your account wisely so you do not overdraw.");
            }

            return Balance -= (amount + fee);
        }

        /// <summary>
        /// Adds interest to the account.
        /// </summary>
        /// <returns>The new balance of the account.</returns>
        public double AddInterest() => Balance *= (1 + Rate);

        /// <summary>
        /// Displays the information of the account.
        /// </summary>
        public void DisplayAccount() => 
            Console.WriteLine($"{AccountNumber}\t{Name}\t{_balance:c}");
    }
}