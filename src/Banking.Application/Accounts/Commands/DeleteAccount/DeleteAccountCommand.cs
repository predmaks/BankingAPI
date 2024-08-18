using MediatR;

namespace Banking.Application.Accounts.Commands.DeleteAccount
{
    public class DeleteAccountCommand : IRequest
    {
        public Guid UserId { get; set; }
        public required string AccountNumber { get; set; }
    }
}
