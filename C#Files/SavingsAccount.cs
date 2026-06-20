using System;

public class SavingsAccount : Account
{
	private decimal minBalance;
	private decimal rate = 0.06m;
	public SavingsAccount(decimal balance, string owner, int id)
		: base(balance, owner, id)
	{
		minBalance = balance;
	}
	public decimal Interest
	{
		get
		{
			return minBalance * rate/12;
		}
	}
	new public void Withdraw(decimal amount)
	{
		base.Withdraw(amount);
		if (balance < minBalance)
		{
			minBalance = balance;
		}
	}
	public void Post()
	{
		balance += Interest;
		numXact = 0;
		minBalance = balance;
	}
	new public string GetStatement()
	{
		string s = base.GetStatement();
        s += $", interest = {Interest}";
        return s;
	}
	public decimal Rate
	{
		get
		{
			return rate;
		}
		set
		{
			rate = value;
		}
	}
}
