

namespace BankAccountClass
{
    class Program
    {
        static void Main(string[] args)
        {/*
            //the client seamlessly perform their desired transactions
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

            
            //the client has a smaller balance than the money the intent to withdraw.
            BankAccount client2 = new BankAccount("Gaspar Prim Díaz", 400.00m);

            Console.WriteLine($"Client {client2.ID}\n");

            client2.Withdraw(500.00m);

            client2.Deposit(200.00m);


            Console.WriteLine($"{client2.AccountOwner} has the following transition history: \n");

            foreach (string trans in client2.Transactions)
            {
                Console.WriteLine(trans);

            }
         
            //the client intents depositing a negative amount

            BankAccount client3 = new BankAccount("Juliana Savioli", 500.00m);

            Console.WriteLine($"Client {client3.ID}\n");

            client3.Deposit(-500.00m);

            client3.Withdraw(200.00m);

            client3.Deposit(200.00m);


            Console.WriteLine($"{client3.AccountOwner} has the following transition history: \n");

            foreach (string trans in client3.Transactions)
            {
                Console.WriteLine(trans);

            }

            //the client intents inputing a negative amount for their initial balance
            BankAccount client4 = new BankAccount("Steven Morrissey", -200.00m);

            Console.WriteLine($"Client {client4.ID}\n");

            client4.Deposit(100.00m);

            client4.Deposit(800.00m);

            client4.Withdraw(470.89m);

            client4.Deposit(200.00m);


            Console.WriteLine($"{client4.AccountOwner} has the following transition history: \n");

            foreach (string trans in client4.Transactions)
            {
                Console.WriteLine(trans);

            }
*/
            //the client intents inputing a negative amount for their initial balance
            BankAccount client5 = new BankAccount("Nicholas O'Malley", 700.00m);

            Console.WriteLine($"Client {client5.ID}\n");

            client5.Withdraw(-300.00m);

            client5.Deposit(400.00m);

            client5.Withdraw(57.34m);

            client5.Deposit(233.99m);


            Console.WriteLine($"{client5.AccountOwner} has the following transition history: \n");

            foreach (string trans in client5.Transactions)
            {
                Console.WriteLine(trans);

            }



        }

         

    }

}