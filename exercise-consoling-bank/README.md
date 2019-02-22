# Lösningsförslag

## Uppgift

[Tröstrika banken](https://coursepress.gitbook.io/1dv024/ovningsuppgifter/del-2/trostrika-banken)

## Diskussion

### Account.cs

```c#
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
        /// <param name="accountNUmber">The number identifying the account.</param>
        /// <param name="balance">The balance of the account.</param>
        public Account(string name, int accountNUmber, double balance)
        {
            Name = name;
            AccountNumber = accountNUmber;
            Balance = balance;
        }

        /// <summary>
        /// The number identifying the account.
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
        /// Withdraws money from the account and returning the new balance.
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
```

Fälten deklareras lämpligen som privata så dess värden inte kan manipuleras. Publika metoder får istället användas för att kontrollera så att det t.ex. inte går att ta ut mer pengar än vad som finns på kontot.

Den enda konstruktorn initierar objektet med de värden som önskas. Lägg märke till att konstruktorn använder sig av egenskapen `Balance` för att initiera det privata fältet `_balance`. Varför? Därför att det inte ska vara möjligt att skapa ett `Account`-objekt med ett negativt tillgodohavande. Man vill ju inte börja med att vara skyldig banken pengar. Eller?

Då ett `Account`-objekt väl har blivit skapat ska kontonumret och namnet inte kunna ändras, därför har egenskaperna `AccountNumber` och `Name` endast en `get`-metod. Egenskaperna blir då vad som kallas _"immutable"_, d.v.s. det går bara att tilldela dem ett värde i konstruktorn och de går bara därefter att läsa.

Egenskapen `Balance` har en publik `get`-metod som returnerar tillgodohavandet. `set`-metoden är däremot privat och används av klassen ”internt” för att ändra värdet som det privata fältet `_balance` har.

Metoderna `Deposit`, `Withdraw` och `AddInterest` påverkar alla på något sätt det privata fältet `_balance`. Diverse kontroller görs för att säkerställa att `_balance` inte blir negativt.

Metoden `DisplayAmount` presenterar en textbeskrivning av ett `Account`-objekts status. (Lämpligare hade det varit att överskugga metoden `ToString`, men aktuell lösning fungerar tillfredsställande i denna uppgift.)