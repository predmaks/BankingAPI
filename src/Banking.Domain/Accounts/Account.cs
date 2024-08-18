using Banking.Common;
using Banking.Domain.Common;
using Banking.Domain.Users;
using System.ComponentModel.DataAnnotations;

namespace Banking.Domain.Accounts
{
    public class Account : IEntity
    {
        public Guid Id { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        // TODO: other account realted properties...

        private User _user;

        public Account(User user, string accountNumber)
        {
            Id = Guid.NewGuid();
            AccountNumber = accountNumber;
            Balance = Consts.Business.MIN_BALANCE;
            _user = user;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ValidationException(
                    "The amount being deposited must be greater than $0.");
            }

            if (amount > Consts.Business.MAX_DEPOSIT_AMOUNT)
            {
                throw new ValidationException(
                    $"The maximum amount that can be deposited cannot be greater than " +
                    $"${Consts.Business.MAX_DEPOSIT_AMOUNT}.");
            }

            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            var maxWithdrawalAmount = Balance * Consts.Business.MAX_WITHDRAWAL_PERCENTAGE;

            if (amount > maxWithdrawalAmount)
            {
                throw new ValidationException(
                    $"The maximum to be withdrawn is " +
                    $"{Consts.Business.MAX_WITHDRAWAL_PERCENTAGE * 100} " +
                    $"percent from the account balance.");
            }

            Balance -= amount;

        }
    }
}
