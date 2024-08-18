using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Banking.Api.Contracts;
using Banking.Application.Accounts.Commands.CreateAccount;
using Banking.Application.Accounts.Commands.DeleteAccount;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Banking.Api.Controllers.v1
{
    [Route("api/users/{userId}/accounts")]
    [ApiController]
    [ApiVersion("1.0")]
    public class AccountsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly Serilog.ILogger _logger;

        public AccountsController(IMediator mediator, Serilog.ILogger logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        // POST api/<AccountsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateAccountRequest))]
        public async Task<ActionResult<CreateAccountRequest>> CreateAccount(Guid userId, CreateAccountRequest createAccountRequest, CancellationToken cancellationToken)
        {
            try
            {
                var createAccountCommand = new CreateAccountCommand
                {
                    UserId = userId,
                    AccountNumber = createAccountRequest.AccountNumber,
                    AccountBalance = createAccountRequest.Balance
                };

                await _mediator.Send(createAccountCommand, cancellationToken);

                return Created($"api/users/{userId}/accounts/{createAccountRequest.AccountNumber}", createAccountRequest);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred when creating account.");

                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<AccountsController>/5
        [HttpDelete("{acountNumber}")]
        public async Task<ActionResult<DeleteAccountRequest>> DeleteAccount(Guid userId, string accountNumber, CancellationToken cancellationToken)
        {
            try
            {
                var deleteAccountCommand = new DeleteAccountCommand
                {
                    UserId = userId,
                    AccountNumber = accountNumber //deleteAccountRequest.AccountNumber
                };

                await _mediator.Send(deleteAccountCommand, cancellationToken);

                return NoContent();
            }
            /*catch (AccountNotExistingException ex)
            {
                return NotFound(ex.Message);
            }*/
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred when deleting account.");

                return BadRequest(ex.Message);
            }
        }

        /*[HttpPut("{acountNumber}")]
        public async Task<ActionResult<DepositMoneyRequest>> DepositMoney(Guid userId, string accountNumber, CancellationToken cancellationToken)
        {
            try
            {
                
            }
            catch (AccountNotExistingException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error occurred when deleting account.");

                return BadRequest(ex.Message);
            }
        }*/
    }
}
