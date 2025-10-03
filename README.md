UML for the BankAccount Class

                    BankAccount
---------------------------------------
- <static> nextId : int;
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
<img width="1225" height="460" alt="Captura de pantalla 2025-10-02 221952" src="https://github.com/user-attachments/assets/a52d4a0b-150b-4b4d-b113-9684131ca6e3" />

second test case
the client has a smaller balance than the money the intent to withdraw.
<img width="601" height="174" alt="image" src="https://github.com/user-attachments/assets/7381a927-9369-4625-868d-fc4265ab852d" />

third test case
the client intents depositing a negative amount.
<img width="978" height="429" alt="Captura de pantalla 2025-10-02 222601" src="https://github.com/user-attachments/assets/6e1370e9-2c7f-499d-924a-88774489de5b" />

fourth test case
the client intents inputing a negative amount for their initial balance.-
<img width="1168" height="577" alt="Captura de pantalla 2025-10-02 222936" src="https://github.com/user-attachments/assets/8b463c76-bafa-4473-bff3-e605dcfe4670" />

fifth test case
the client intents inputing a negative amount for one of their withdrawals.
<img width="569" height="263" alt="image" src="https://github.com/user-attachments/assets/45289ba3-3a6f-47b4-ac35-420e72bfc6ca" />



