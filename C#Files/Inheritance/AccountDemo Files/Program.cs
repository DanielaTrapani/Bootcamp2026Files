namespace AccountDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(300, "Daniela");
            //acc.Owner = "Daniela";
            acc.Deposit(200);
            acc.Withdraw(800);
            Console.WriteLine($"Hello {acc.Owner}, ID {acc.Id}, your balance is {acc.Balance:c}");

            CheckingAccount chk = new CheckingAccount(1000,"Patrick");
            //chk.Owner = "Patrick";
            chk.Deposit(1000);
            //chk.Withdraw(100);
            Console.WriteLine($"Hello {chk.Owner}, ID {chk.Id}, your balance is {chk.Balance:c}, Check book ordered: {chk.OrderCheckBook()}");


            Console.ReadLine();
        }
    }
}
