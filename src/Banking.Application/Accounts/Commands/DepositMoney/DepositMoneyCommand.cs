using MediatR;

namespace Banking.Application.Accounts.Commands.DepositMoney
{
    public class DepositMoneyCommand : IRequest
    {
        public Guid UserId { get; set; }
        public required string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
