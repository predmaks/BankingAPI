using MediatR;
using Banking.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.Accounts.Commands.DepositMoney
{
    internal class DepositMoneyHandler : IRequestHandler<DepositMoneyCommand>
    {
        private readonly IDatabaseService _database;

        public DepositMoneyHandler(IDatabaseService database) => _database = database;

        public async Task Handle(DepositMoneyCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
