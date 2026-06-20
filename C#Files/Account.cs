public abstract class Account
{
    private int id;
    protected decimal balance;
	private string owner;
	protected int numXact = 0;	// number of transactions
	public Account(decimal balance, string owner, int id)
	{
		this.balance = balance;
		this.owner = owner;
		this.id = id;
	}
	virtual public void Deposit(decimal amount)
	{
		balance += amount;
		numXact++;
	}
    virtual public void Withdraw(decimal amount)
	{
		balance -= amount;
		numXact++;
	}
	public decimal Balance
	{
		get
		{
			return balance;
		}
	}
	public int Id
	{
		get
		{
			return id;
		}
	}
	public string Owner
	{
		get
		{
			return owner;
		}
		set
		{
			owner = value;
		}
	}
	public int Transactions
	{
		get
		{
			return numXact;
		}
	}
    virtual public string GetStatement()
	{
		string s = $"Statement for {Owner}, id = {Id}, {Transactions} transactions, balance = {balance}";
		return s;
	}
	abstract public void Post();
	abstract public string Prompt { get; }
    virtual public void MonthEnd()
    {
        numXact = 0;
    }
}