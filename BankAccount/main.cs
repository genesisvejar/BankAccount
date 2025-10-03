

namespace BankAccountClass
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount client1 = new BankAccount("Mary Jane", 1000.00m);

            Console.WriteLine($"Client {client1.ID}\n");

            client1.Deposit(800.00m);

            client1.Withdraw(400.00m);

            client1.Deposit(700.00m);

            Console.WriteLine($"{client1.AccountOwner} has the following transition history: \n");

            foreach (string trans in client1.Transactions)
            {
                Console.WriteLine(trans);
            }

            Console.WriteLine();
            

            //if the client has a smaller balance than the money the want to withdraw.
            BankAccount client2 = new BankAccount("Gaspar Prim Díaz", 400.00m);

            Console.WriteLine($"Client {client2.ID}\n");

            client2.Withdraw(500.00m);

            client2.Deposit(200.00m);


            Console.WriteLine($"{client2.AccountOwner} has the following transition history: \n");

            foreach (string trans in client2.Transactions)
            {
                Console.WriteLine(trans);
                
            }


        }

    }

}