namespace ActBalCalc.Models
//may not need the "get" methods since I am working off of a java project description
//Reminder: .NET get/set handles this functionality
{
    public class Account : Depositable, Withdrawable
    {
        public decimal Balance { get; set; }

        public void deposit(decimal amount)
        {
            Balance += amount;
        }

        public void withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
