namespace moreMikeDemos.Classes
{
    abstract internal class BankAccount
    {
        //properties:
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int OwnerId { get; set; }
        public decimal Balance { get; set; }
        public string BranchManager { get; set; }

        //methods
        abstract public void CloseAccount();


    }

    class CheckingAccount : BankAccount
    {
        public int LastCheckNumber { get; set; }
        public override void CloseAccount()
        {
            //TODO: write close code
            throw new NotImplementedException();
        }
    }

    class BusinessCheckingAccount : CheckingAccount
    {
        public string BusinessFedID { get; set; }
    }

    sealed class SavingsAccount : BankAccount
    {
        //variables
        private decimal defaultInterestRate = .01M;
        public decimal InterestRate { get; set; }
        public string AccountType { get; set; }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }
    }

}
