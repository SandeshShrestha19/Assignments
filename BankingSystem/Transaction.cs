using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public TransactionType TypeOfTransaction { get; set; } // withdraw or deposit
        private decimal Amount {  get; set; }
        public DateTime DateTime {  get; set; }

        public Transaction(int transactionId, TransactionType typeOfTransaction, decimal amount)
        {
            this.TransactionId = transactionId;
            TypeOfTransaction = typeOfTransaction;
            Amount = amount;
            DateTime = System.DateTime.UtcNow;
        }
        public string DisplayTransactionInformation()
        {
            return $"[ID: {TransactionId}] {TypeOfTransaction} of {Amount} on {DateTime}";
        }
    }
}
