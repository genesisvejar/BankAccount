/* Implement a class called BankAccount

including UML design OK and test cases in the README of GitHub

Keeps track of account id, balance, transactions, note: use properties to access these instance variables

An account can be created given the customer name, initial balance, OK

Create deposit and withdrawal methods.

Test the methods in the BankAccount class using the above test cases, considering all possible success and failure cases*/

/*              BankAccount
---------------------------------------
- <static> nextId : int;
- id : int;
- balance : decimal;                     
- accountOwner : string;
---------------------------------------
 + BankAccount(string, decimal);
 + Id : int {get}
 + Balance : decimal {get};
 + AccountOwner : string {get};
 + Transactions : List <string> {get};
 + deposit (decimal) : void;
 + withdrawal (decimal) : void;

*/
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
        balance = initialBalance;
        id = nextId;
        nextId++;

        transactions= new List<string>();
        transactions.Add($"Your current balance is: {balance}");

    }

    //Properties
    public int ID { get { return id; } }

    public decimal Balance { get { return balance; } }

    public List<string> Transactions { get { return transactions; } }

    public string AccountOwner { get { return accountOwner; } }
    
    //


    }