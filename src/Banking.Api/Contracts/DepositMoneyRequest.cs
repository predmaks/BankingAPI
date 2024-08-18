namespace Banking.Api.Contracts
{
    public class DepositMoneyRequest
    {
        public required string AccountNumber { get; set; }
        public decimal Amount { get; set; }
    }
}
