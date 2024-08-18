namespace Banking.Api.Contracts
{
    public class WithdrawMoneyRequest
    {
        public required string AccountNumber { get; set; }
        public decimal Amount { get; set; }
    }
}
