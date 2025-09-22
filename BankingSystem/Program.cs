using System;
using BankingSystem;

class Program
{
    static void Main(string[] args)
    {
        var accountOne = new BankAccount("12345678", "Ram Bahadur", 45605);
        var accountTwo = new BankAccount("12875678", "Shyam Krishna", 106605);

        var transactionList = new List<Transaction>();
        var initialTransactionId = 1001;

        accountOne.Deposit(3000);

        transactionList.Add(new Transaction(initialTransactionId++, TransactionType.Deposit, 3000));

        //accountTwo.Withdraw(2000);
        //transactionList.Add(new Transaction(initialTransactionId++, "Withdraw", 2000));

        //accountTwo.Deposit(7000);
        //transactionList.Add(new Transaction(initialTransactionId++, "Deposit", 7000));

        accountOne.CheckBalance();

        Console.WriteLine();

        Console.WriteLine("|----Transaction History----|");
        foreach(var transaction in transactionList)
        {
            string transactionInformation = transaction.DisplayTransactionInformation();
            Console.WriteLine(transactionInformation);
        }

        Console.ReadKey();
    }
}
