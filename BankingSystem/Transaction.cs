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
        public string TypeOfTransaction { get; set; } // wtihdraw or deposit
        public decimal Amount {  get; set; }
        public DateTime DateTime {  get; set; }

        public Transaction(int transactionId, string typeOfTransaction, decimal amount)
        {
            TransactionId = transactionId;
            TypeOfTransaction = typeOfTransaction;
            Amount = amount;
            DateTime = System.DateTime.Now;
        }
        public override string ToString()
        {
            return $"[ID: {TransactionId}] {TypeOfTransaction} of {Amount} on {DateTime}";
        }
    }
}
