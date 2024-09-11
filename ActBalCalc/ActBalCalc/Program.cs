using ActBalCalc.Models;

namespace ActBalCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSectionHeader("Welcome to the account application.");
            Console.WriteLine();
            
            PrintSectionHeader("Starting Balances");
            CheckingAccount ca1 = new CheckingAccount(1000.00M, 1.00M);
            SavingsAccount sa1 = new SavingsAccount(1000.00M, .01);
            DisplayBalances(ca1, sa1);
            
            Console.WriteLine("\nEnter the transactions for the month\n");

            string choice = "y";
            while (choice == "y")
            {
                //todo while loop here
                string action = GetString("Withdrawal or Deposit (w/d)? ", "w", "d");
                string account = GetString("Checking or savings? (c/s) ", "c", "s");

                //defaulting to neither
                Account selectedAccount = null;

                //defaulting to anything from a penny to infinity
                decimal maxAmount = Decimal.MaxValue;
                decimal minAmount = .01M;

                if (account == "c") {selectedAccount = ca1;}
                else if (account == "s") {selectedAccount = sa1;}



                if (action == "w" && selectedAccount.Balance <= 0)
                {
                    Console.WriteLine("Insufficient funds.");
                    continue;
                }
                else if (action == "w")
                {
                    maxAmount = selectedAccount.Balance;
                }
      
                decimal amount = GetDecimal("Amount? ", minAmount, maxAmount);

                if (action == "w") {
                    selectedAccount.withdraw(amount);
                }
                else { selectedAccount.deposit(amount); }


                choice = GetString("\nContinue? (y/n): ", "y", "n");
            }

            //todo end loop
            sa1.ApplyPayment();
            ca1.SubtractMonthlyFee();
            Console.WriteLine("\nMonthly Payments and fees");
            Console.WriteLine($"Checking fee:\t\t\t{ca1.MonthlyFee:c}");
            Console.WriteLine($"Savings interest payment:\t{sa1.MonthlyInterestPayment:c}");

            Console.WriteLine("\nFinal Balances");
            DisplayBalances(ca1, sa1);

        }

        //Making sure they cannot overdraft (validation)
        private static decimal GetDecimal(string prompt, decimal min, decimal max)
        {
            decimal number = 0.0M;
            Boolean isValid = false;

            while (!isValid)
            {
                Console.Write(prompt);
                Boolean success = Decimal.TryParse(Console.ReadLine(), out number);
                if (!success)
                {
                    Console.WriteLine("Invalid entry: please enter a valid double.");
                }
                else
                {
                    if (number < min)
                    {
                        Console.WriteLine($"Invalid entry: amount must be greater than {min:c}");
                        continue;
                    }
                    else if (number > max)
                    {
                        Console.WriteLine($"Invalid entry: amount must be less than {max:c}");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return number;
        }

        //to print out the balances
        private static void DisplayBalances(CheckingAccount ca1, SavingsAccount sa1)
        {
            Console.WriteLine($"Checking: \t{ca1.Balance:c}");
            Console.WriteLine($"Savings: \t{sa1.Balance:c}");
        }

        //to make pretty headers
        private static void PrintSectionHeader(string sectionHeader)
        {
            Console.WriteLine(GetSeparator('=', sectionHeader.Length));
            Console.WriteLine(sectionHeader);
            Console.WriteLine(GetSeparator('=', sectionHeader.Length));
        }

        private static string GetSeparator(char separator, int length)
        {
            string separatorString = "=";
            separatorString = separatorString.PadRight(length, '=');
            return separatorString;
        }

        //this is how to prompt the user and get their feedback
        private static string GetString(string prompt, string s1, string s2)
        {
            string strValue = "";
            Boolean isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                strValue = Console.ReadLine().ToLower();
                if (strValue == "")
                {
                    Console.WriteLine("Error: entry is required.");
                    continue;
                }
                else if (strValue != s1 && strValue != s2)
                {
                    Console.WriteLine($"Error: entry must be either '{s1}' or '{s2}'.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return strValue;
        }
    }
}
