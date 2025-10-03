/* Implement a class called BankAccount

including UML design OK and test cases in the README of GitHub

Keeps track of account id, balance, transactions, note: use properties to access these instance variables OK

An account can be created given the customer name, initial balance, OK

Create deposit and withdrawal methods. OK

Test the methods in the BankAccount class using the above test cases, considering all possible success and failure cases*/

/*              BankAccount
---------------------------------------
- <<static>> nextId : int;
- id : int;
- balance : decimal;                     
- accountOwner : string;
---------------------------------------
 + BankAccount(string, decimal);
 + Id : int {get}
 + Balance : decimal {get};
 + AccountOwner : string {get};
 + Transactions : List <string> {get};
 + Deposit (decimal) : void;
 + Withdrawal (decimal) : void;

*/
namespace BankAccountClass
{
    public class BankAccount
    {
        //Fields
        private static int nextId = 1000;
        private int id;
        private decimal balance;
        private List<string> transactions;
        private string accountOwner;

        //Constructor
        public BankAccount(string name, decimal initialBalance)
        {
            accountOwner = name;
            balance = (initialBalance < 0) ? 0 : initialBalance;
            id = nextId;
            nextId++;

            transactions = new List<string>();
            transactions.Add($"Your initial balance is ${balance}.\n");

        }

        //Properties
        public int ID { get { return id; } }

        public decimal Balance { get { return balance; } }

        public List<string> Transactions { get { return transactions; } }

        public string AccountOwner { get { return accountOwner; } }

        //Methods
        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine($"Unsuccessful {amount} deposit. Deposit a positive amount.\n");
            }
            else
            {
                balance += amount;
                Console.WriteLine($"You've successfully deposited ${amount}.\n");
                transactions.Add($"You've made a ${amount} deposit. Your current balance is ${balance}.\n");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine($"Your account doesn't have sufficient funds to perform this ${amount} withdrawal.");
                Console.WriteLine($"Your current balance is ${balance}.\n");
            }
            else if (amount < 0)
            {
                Console.WriteLine($"Unsuccessful {amount} withdrawal. Withdraw a positive amount.\n");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"You've successfully withdrawn ${amount}.\n");
                transactions.Add($"You've made a ${amount} withdrawal. Your current balance is ${balance}.\n");
            }

        }
    }

}