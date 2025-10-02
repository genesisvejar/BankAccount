UML for the BankAccount Class

              BankAccount
---------------------------------------
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
