namespace Homework3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Interest Calculator!");

            string choice = "y";
            while (choice == "y") {

                Console.WriteLine();
                Console.Write("Enter loan amount: ");
                double loan = double.Parse(Console.ReadLine());

                Console.Write("Enter interest rate: ");
                double rInterest = double.Parse(Console.ReadLine());
                double interest = Math.Round(rInterest, 5);
                double loanInterest = Math.Round(loan * interest, 2);

                Console.WriteLine();
                Console.WriteLine($"Loan Amount: {loan.ToString("c")}");
                Console.WriteLine($"Interest Rate: ${interest.ToString("p3")}");
                Console.WriteLine($"Interest: {loanInterest.ToString("c")}");

                Console.WriteLine();
                Console.Write("Continue?  (y/n): ");
                choice = Console.ReadLine();
            
            
            
            
            
            
            
            
            }
        }
    }
}
