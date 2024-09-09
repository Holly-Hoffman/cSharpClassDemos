using moreMikeDemos.Classes;
using System.Threading.Channels;

namespace moreMikeDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //todo: add copywrite
            Console.WriteLine("Hello, World!");

            //BankAccount acct1 = new BankAccount();
            //BankAccount acct2 = new();
            //var acct3 = new BankAccount();

            //acct1.Balance = 1000;
            //acct1.OwnerId = 1;
            //acct1.AccountName = "Fun Spending";
            //acct1.AccountNumber = 123456;

            CheckingAccount ck1 = new CheckingAccount();
            ck1.Balance = 500;
            ck1.OwnerId = 1;
            ck1.AccountName = "Responsible Spending";
            ck1.AccountNumber = 123457;
            ck1.LastCheckNumber = 99999;
            ck1.CloseAccount();

            SavingsAccount sav1 = new();
            sav1.Balance = 100;
            sav1.OwnerId = 1;
            sav1.AccountName = "College fund";
            sav1.AccountNumber = 1234568;
            sav1.InterestRate = 15.7M;
            sav1.AccountType = "Education";
            sav1.CloseAccount();

        }
    }
}
