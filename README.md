UML for the BankAccount Class

                    BankAccount
---------------------------------------
- <<static>> nextId : int;
- id : int;
- balance : decimal;
- transactions : List <string> ;
- accountOwner : string;
---------------------------------------
 + BankAccount(string, decimal);
 + Id : int {get}
 + Balance : decimal {get};
 + AccountOwner : string {get};
 + Transactions : List <string> {get};
 + deposit (decimal) : void;
 + withdrawal (decimal) : void;


first test case
the client seamlessly perform their desired transactions.
<img width="1128" height="716" alt="image" src="https://github.com/user-attachments/assets/c190fbb4-6a31-49dc-bf6f-ef8f4ac52720" />

second test case
the client has a smaller balance than the money the intent to withdraw.
<img width="601" height="174" alt="image" src="https://github.com/user-attachments/assets/7381a927-9369-4625-868d-fc4265ab852d" />

third test case
the client intents depositing a negative amount.
<img width="1128" height="716" alt="image" src="https://github.com/user-attachments/assets/5046f802-2c6d-4f79-9b98-7d2f15d20bbd" />


fourth test case
the client intents inputing a negative amount for their initial balance.
<img width="1128" height="716" alt="image" src="https://github.com/user-attachments/assets/aee51314-8212-4a9d-9a93-aa8ae514b3a2" />


fifth test case
the client intents inputing a negative amount for one of their withdrawals.
<img width="1128" height="716" alt="image" src="https://github.com/user-attachments/assets/a2df32a1-bacc-4ac9-a059-773e5e715ced" />



