using System;
using Dapper;
using Npgsql;
using SystemAssignment.Models;
using SystemAssignment.Constants;

namespace SystemAssignment.Services
{
    public class BankService // BankService
    {
        public async Task CreateAccountAsync(BankAccount bankAccount)
        {
             var createAccountQuery = @"insert into account_info (""account_number"",""account_holder_name"", ""balance"") val (@AccountNumber, @HolderName, @Balance)";
             using (var connection = new NpgsqlConnection(DatabaseConnectionConstants.connectionString))
             {
                 await connection.OpenAsync();
                 await connection.ExecuteAsync(createAccountQuery, bankAccount);
             }
            
        }
        public static async Task<BankAccount> CheckBalanceAsync(int accountNumber)
        {
            var checkBalanceQuery = @"SELECT ""account_number"", ""account_holder_name"", ""balance""
                                      FROM account_info
                                      WHERE ""account_number"" = @AccountNumber";

            using (var connection = new NpgsqlConnection(DatabaseConnectionConstants.connectionString))
            {
                await connection.OpenAsync();

                var account = await connection.QueryFirstOrDefaultAsync<BankAccount>(checkBalanceQuery, new
                    {
                        AccountNumber = accountNumber
                    });
                return account;
            }
        }

        public static async Task<bool> WithdrawAmountAsync(BankAccount bankAccount)
        {
            var withdrawQuery = @"UPDATE account_info 
                                 SET balance = balance - @Amount 
                                 WHERE account_number = @AccountNumber ";

            using (var connection = new NpgsqlConnection(DatabaseConnectionConstants.connectionString))
            {
                await connection.OpenAsync();
                var affectedRows = await connection.ExecuteAsync(
                    withdrawQuery,
                    new
                    {
                        AccountNumber = bankAccount.AccountNumber,
                        Amount = bankAccount.Balance
                    });

                return affectedRows > 0;
            }
        }

        public static async Task<bool> DepositAmountAsync(BankAccount bankAccount)
        {
            var depositQuery = @"
                                UPDATE account_info 
                                SET balance = balance + @Amount 
                                WHERE account_number = @AccountNumber";

            using (var connection = new NpgsqlConnection(DatabaseConnectionConstants.connectionString))
            {
                await connection.OpenAsync();
                var affectedRows = await connection.ExecuteAsync(
                    depositQuery,
                    new
                    {
                        AccountNumber = bankAccount.AccountNumber,
                        Amount = bankAccount.Balance
                    });

                return affectedRows > 0;
            }
        }


    }
}
