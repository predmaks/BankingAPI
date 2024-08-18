using Banking.Common;
using System.ComponentModel.DataAnnotations;

namespace Banking.Api.Contracts
{
    public class CreateAccountRequest
    {
        [Required]
        [StringLength(Consts.Validation.BANK_ACCOUNT_NUMBER_LENGTH)]
        // TODO: Regex validation for the account number
        public required string AccountNumber { get; set; }

        [Required]
        public decimal Balance { get; set; }
    }
}
