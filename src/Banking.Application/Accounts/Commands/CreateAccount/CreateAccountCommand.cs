using MediatR;

namespace Banking.Application.Accounts.Commands.CreateAccount
{
    public class CreateAccountCommand : IRequest
    {
        public Guid UserId { get; set; }
        public required string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
