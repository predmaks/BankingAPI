namespace Banking.Common
{
    public static class Consts
    {
        public static class Validation
        {
            public const int BANK_ACCOUNT_NUMBER_LENGTH = 16;
        }

        public static class Business
        {
            public const decimal MIN_BALANCE = 100M;
            public const decimal MAX_WITHDRAWAL_PERCENTAGE = 0.9M;
            public const int MAX_DEPOSIT_AMOUNT = 10000;
        }
    }
}
