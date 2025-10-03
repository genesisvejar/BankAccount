

namespace BankAccountClass
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount client1 = new BankAccount("Mary Jane", 1000.00m);

            // what if we have integers ?????

            client1.Deposit(800.00m);

            client1.Withdraw(400.00m);

            client1.Deposit(700.00m);

            Console.WriteLine($"{client1.AccountOwner} has the following transition history: \n");

            foreach (string trans in client1.Transactions)
            {
                Console.WriteLine(trans);
            }

           


        }

    }

}