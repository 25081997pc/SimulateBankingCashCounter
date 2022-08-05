namespace SimulateBankingCashCounter
{
    class Program
    {
        public static void Main(string[] args)
        {
            BankingCashCounter cashCounter = new BankingCashCounter();
            cashCounter.updateCash();
        }
    }
}