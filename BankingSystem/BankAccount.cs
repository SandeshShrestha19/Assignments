using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string HolderName { get; set; }
        public decimal Balance { get; set; } = 0;

        public BankAccount(string accountNumber, string holderName, decimal balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }
        public decimal Deposit(decimal depositAmount)
        {
            if (depositAmount <= 0)
            {
                Console.WriteLine("Error: Deposit amount must be positive.");
                return Balance;
            }
            Balance += depositAmount;
            Console.WriteLine($"Your new balance is {Balance}.");
            return Balance;
        }
        public decimal Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount <= 0)
            {
                Console.WriteLine("Error: Withdrawal amount must be positive.");
                return Balance;
            }
            if (Balance >= withdrawAmount)
            {
                Balance -= withdrawAmount;
                Console.WriteLine($"{withdrawAmount} has been withdrawn. Remaining balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Error: Insufficient balance!");
            }
            return Balance;
        }
        public void CheckBalance()
        {
                Console.WriteLine($"The total balance of your account is {Balance}.");
        }
    }
}
