using System;
using BankingSystem;

class Program
{
    static void Main(string[] args)
    {
        BankAccount accountOne = new BankAccount("12345678", "Ram Bahadur", 45605);
        BankAccount accountTwo = new BankAccount("12875678", "Shyam Krishna", 106605);

        List<Transaction> transactionList = new List<Transaction>();
        int initialTransactionId = 1001;

        accountOne.Deposit(3000);
        transactionList.Add(new Transaction(initialTransactionId++, "Deposit", 3000));

        //accountTwo.Withdraw(2000);
        //transactionList.Add(new Transaction(initialTransactionId++, "Withdraw", 2000));

        //accountTwo.Deposit(7000);
        //transactionList.Add(new Transaction(initialTransactionId++, "Deposit", 7000));

        accountOne.CheckBalance();

        Console.WriteLine();

        Console.WriteLine("|----Transaction History----|");
        foreach(var transaction in transactionList)
        {
            Console.WriteLine(transaction);
        }

        Console.ReadKey();
    }
}
