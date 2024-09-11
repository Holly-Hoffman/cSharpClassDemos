namespace ActBalCalc.Models
{
    public class SavingsAccount : Account
    {
        public double MonthlyInterestRate { get; set; }
        public decimal MonthlyInterestPayment { get; set; }

        public SavingsAccount(decimal initialBalance, double monthlyInterestRate)
        {
            base.Balance = initialBalance;
            MonthlyInterestRate = monthlyInterestRate;
        }
        //methods
        public void ApplyPayment()
        {
            //calc mthly interest paymt (balance * mthly interest rate)
            //set mthly int paymt
            //set  base.balance += mthlt int pay
            MonthlyInterestPayment = base.Balance * (decimal)MonthlyInterestRate;
            base.Balance += MonthlyInterestPayment;
        }
    }
}
