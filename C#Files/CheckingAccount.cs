using System;
using TestBank;
public class CheckingAccount : Account, IStatement
{
	private decimal fee = 5.00m;
	private const int FREEXACT = 2;
	public CheckingAccount(decimal balance, string owner, int id)
		: base(balance, owner, id)
	{
	}
	public decimal Fee
	{
		get
		{
			if (numXact > FREEXACT)
				return fee;
			else
				return 0.00m;
		}
	}
	override public string GetStatement()
	{
		string s = base.GetStatement();
        s += $", fee = {Fee}";
        return s;
	}
	public void Post()
	{
		balance -= Fee;
	}

    public string Prompt
	{
        get
        {
            return "Checking: ";
        }
    }
}
