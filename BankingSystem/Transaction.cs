using System;
using System.Collections.Generic;
using System.Linq;
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
            TransactionId = transactionId;
            TypeOfTransaction = typeOfTransaction;
            Amount = amount;
            DateTime = System.DateTime.Now;
        }
        public string DisplayTransactionInformation()
        {
            return $"[ID: {TransactionId}] {TypeOfTransaction} of {Amount} on {DateTime}";
        }
    }
}
