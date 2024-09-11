namespace ActBalCalc.Models
{
    public class CheckingAccount : Account
    {
        public decimal MonthlyFee { get; set; }

        public CheckingAccount(decimal initialDeposit, decimal monthlyFee)
        {
            base.Balance = initialDeposit;
            MonthlyFee = monthlyFee;
        }
        //methods
        public void SubtractMonthlyFee()
        {
            base.Balance -= MonthlyFee;
        }
    }
}
