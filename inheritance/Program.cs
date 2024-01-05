namespace inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Account class
            Account myAccount = new Account();
            double currentAmount = 0.0;
            // save money in my current account
            currentAmount = myAccount.setAccountBalance(1000.00);
            Console.WriteLine($"current amount: {currentAmount}");

            //withdraw 200.00
            currentAmount = myAccount.withdrawFromAccount(200.00);
            Console.WriteLine($"current amount: {currentAmount}");

            //get balance
            currentAmount = myAccount.getAccountBalance();
            Console.WriteLine($"current amount: {currentAmount}");
            Console.ReadLine();
        }
    }


    
}
