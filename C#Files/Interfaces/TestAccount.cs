using System;
using TestBank;
public class TestAccount
{
	public static void Main(string[] args)
	{
		CheckingAccount chk = new CheckingAccount(10000, "Charlie", 2);
		chk.Deposit(5000);
		chk.Withdraw(12000);
        ShowAccount(chk);
        chk.Post();
		Console.WriteLine("After posting, balance = {0}", chk.Balance);
		Console.WriteLine();

        // Same starting balance, different transactions
        chk = new CheckingAccount(10000, "Charlie", 2);
		chk.Withdraw(500);
		chk.Withdraw(1000);
		chk.Withdraw(1500);
        ShowAccount(chk);
        chk.Post();
		Console.WriteLine("After posting, balance = {0}", chk.Balance);
        Console.WriteLine();

        // Same transaction streams for savings account
        SavingsAccount sav = new SavingsAccount(10000, "David", 3);
		sav.Deposit(5000);
		sav.Withdraw(12000);
        ShowAccount(sav);
        sav.Post();
		Console.WriteLine("After posting, balance = {0}", sav.Balance);
        Console.WriteLine();

        sav = new SavingsAccount(10000, "David", 3);
		sav.Withdraw(500);
		sav.Withdraw(1000);
		sav.Withdraw(1500);
        ShowAccount(sav);
        sav.Post();
		Console.WriteLine("After posting, balance = {0}", sav.Balance);

        Console.ReadLine();
	}
		private static void ShowAccount(IStatement stmt)
	{
		Console.Write($"{stmt.Prompt}");
		Console.WriteLine(stmt.GetStatement());
	}

}
