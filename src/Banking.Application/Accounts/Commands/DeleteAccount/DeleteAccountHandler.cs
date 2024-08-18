using MediatR;
using Banking.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.Accounts.Commands.DeleteAccount
{
    internal class DeleteAccountHandler : IRequestHandler<DeleteAccountCommand>
    {
        private readonly IDatabaseService _database;

        public DeleteAccountHandler(IDatabaseService database) => _database = database;

        public async Task Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
        {
            var users = await _database.GetAllUsers();

            var user = users
                .Where(user => user.Id.Equals(request.UserId))
                .FirstOrDefault() ?? throw new ArgumentException("Error deleting account, the user does not exist.");

            /*var account = users
                .SelectMany(user => user.Accounts)
                .FirstOrDefault(account => account.AccountNumber == request.AccountNumber)
                 ?? throw new ArgumentException("Error deleting account. The account does not exist!");*/

            user.DeleteAccount(request.AccountNumber);

            await _database.SaveChanges();
        }
    }
}
