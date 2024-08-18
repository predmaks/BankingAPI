using MediatR;

namespace Banking.Application.Accounts.Commands.WithdrawMoney
{
    public class WithdrawMoneyCommand : IRequest
    {
        public Guid UserId { get; set; }
        public required string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
