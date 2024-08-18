using MediatR;
using Banking.Persistence.Interfaces;

namespace Banking.Application.Accounts.Commands.CreateAccount
{
    internal class CreateAccountHandler : IRequestHandler<CreateAccountCommand>
    {
        private readonly IDatabaseService _database;

        public CreateAccountHandler(IDatabaseService database) => _database = database;

        public async Task Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            var users = await _database.GetAllUsers();

            var user = users
                .Where(user => user.Id.Equals(request.UserId))
                .FirstOrDefault() ?? throw new ArgumentException("Error adding account, the user does not exist.");

            user.CreateAccount(request.AccountNumber);

            await _database.SaveChanges();
        }
    }
}
