using MediatR;
using Banking.Persistence.Interfaces;

namespace Banking.Application.Accounts.Commands.WithdrawMoney
{
    internal class WithdrawMoneyHandler : IRequestHandler<WithdrawMoneyCommand>
    {
        private readonly IDatabaseService _database;

        public WithdrawMoneyHandler(IDatabaseService database) => _database = database;

        public async Task Handle(WithdrawMoneyCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
