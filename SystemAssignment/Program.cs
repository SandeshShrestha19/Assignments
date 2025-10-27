using System;
using System.Threading.Tasks;
using SystemAssignment.Models;
using SystemAssignment.Services;
using SystemAssignment.Constants;

class Program
{
    static List<Transaction> transactionList = new List<Transaction>();
    static int transactionIdCounter = 0;
    static async Task Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select a number for respective function: \n" +
                "1. Deposit amount \n" +
                "2. Withdraw amount \n" +
                "3. Check balance \n" +
                "4. Create new account \n" +
                "5. View all transactions");
            var choice = Console.ReadLine();

            var services = new Services();

            switch (choice)
            {
                case "1":
                    await DepositAmount(services);
                    break;
                case "2":
                    await WithdrawAmount(services);
                    break;
                case "3":
                    await CheckBalance();
                    break;
                case "4":
                    await CreateAccount(services);
                    break;
                case "5":
                    await ShowTransactions(transactionList);
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
        static async Task CreateAccount(Services services)
        {
            Console.Write("Enter holder's name: ");
            var holderName = Console.ReadLine();

            var currentBalance = 0;

            Console.Write("Do you want to deposit any amount? (yes/no): ");
            var input = Console.ReadLine().ToLower();


            if (input == "yes")
            {
                Console.Write("Enter the amount you want to deposit? ");
                var depositAmount = Convert.ToInt32(Console.ReadLine());
                currentBalance += depositAmount;
            }

            var account = new BankAccount()
            {
                AccountNumber = new Random().Next(1, 1000),
                HolderName = holderName,
                Balance = currentBalance
            };
            await services.CreateAccountAsync(account);
            Console.WriteLine("Account Created! \n");
        }

        static async Task CheckBalance()
        {
            Console.WriteLine("Enter your account number: ");
            var input = Console.ReadLine();

            if (!int.TryParse(input, out int accountNumber))
            {
                Console.WriteLine("Invalid account number. Please enter a number.");
                return;
            }

            var account = await Services.CheckBalanceAsync(accountNumber);

            if (account != null)
            {
                Console.WriteLine($"The current balance of A/c {accountNumber} is {account.Balance}. \n");
            }
            Console.WriteLine("Account not found.");
        }

        async Task WithdrawAmount(Services services)
        {
            try
            {
                Console.WriteLine("Enter your account number: ");
                var accountInput = Console.ReadLine();

                if (!int.TryParse(accountInput, out int accountNumber) || accountNumber <= 0)
                {
                    Console.WriteLine("Invalid account number. Please enter a positive number.");
                    return;
                }

                Console.Write("Enter the amount to withdraw: ");
                var withdrawingAmount = Convert.ToDecimal(Console.ReadLine());

                var bankAccount = new BankAccount
                {
                    AccountNumber = accountNumber,
                    Balance = withdrawingAmount
                };

                var success = await Services.WithdrawAmountAsync(bankAccount);

                if (success)
                {
                    var updatedAccount = await Services.CheckBalanceAsync(accountNumber);
                    Console.WriteLine($"Withdrawal successful. New balance: {updatedAccount.Balance:C}");
                    transactionList.Add(new Transaction
                    {
                        TransactionId = transactionIdCounter++,
                        TypeOfTransaction = TransactionType.Withdraw,
                        Amount = withdrawingAmount
                    });
                    return;
                }
                Console.WriteLine("Withdrawal failed. Please check account number and balance.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        async Task DepositAmount(Services services)
        {
            try
            {
                Console.WriteLine("Enter your account number: ");
                var accountInput = Console.ReadLine();

                if (!int.TryParse(accountInput, out int accountNumber) || accountNumber <= 0)
                {
                    Console.WriteLine("Invalid account number. Please enter a positive number.");
                    return;
                }

                Console.Write("Enter the amount to deposit: ");
                var depositingAmount = Convert.ToDecimal(Console.ReadLine());

                var bankAccount = new BankAccount
                {
                    AccountNumber = accountNumber,
                    Balance = depositingAmount
                };

                var success = await Services.DepositAmountAsync(bankAccount);

                if (success)
                {
                    var updatedAccount = await Services.CheckBalanceAsync(accountNumber);
                    Console.WriteLine($"Deposit successful. New balance: {updatedAccount.Balance:C}");
                    transactionList.Add(new Transaction
                    {
                        TransactionId = transactionIdCounter++,
                        TypeOfTransaction = TransactionType.Deposit,
                        Amount = depositingAmount
                    });
                    return;
                }
                Console.WriteLine("Deposit failed. Please check account number and balance.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        static async Task ShowTransactions(List<Transaction> transactionList)
        {
            if (transactionList.Count == 0)
            {
                Console.WriteLine("No transactions found.\n");
                return;
            }

            Console.WriteLine("--- Transaction History ---");
            foreach (var transaction in transactionList)
            {
                Console.WriteLine($"ID: {transaction.TransactionId} Type: {transaction.TypeOfTransaction} | Amount:{transaction.Amount:F2} Date: {DateTime.UtcNow}");
            }
            Console.WriteLine();
        }
    }
}


