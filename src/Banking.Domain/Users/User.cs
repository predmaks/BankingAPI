using Banking.Domain.Accounts;
using Banking.Domain.Common;

namespace Banking.Domain.Users
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public string Username { get; set; }

        public List<Account> Accounts { get; set; }

        public User(string username)
        {
            Id = Guid.NewGuid();
            Username = username;

            Accounts = new List<Account>();
        }

        public Account CreateAccount(string accountNumber)
        {
            var account = new Account(this, accountNumber);
            Accounts.Add(account);

            return account;
        }

        public void DeleteAccount(string accountNumber)
        {
            var accountToDelete = Accounts.Where(account => account.AccountNumber == accountNumber).FirstOrDefault();
            
            if (accountToDelete == null)
            {
                throw new ArgumentException($"The acocunt with the number {accountNumber} does not exist");
            }

            Accounts.Remove(accountToDelete);
        }
    }
}
