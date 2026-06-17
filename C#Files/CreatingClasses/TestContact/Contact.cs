// Contact.cs

public class Contact
{
	public const int MAXLENGTH = 20;
	private readonly int id;
	private string name;
	private string email;
	public Contact()
	{
	}
	public Contact(int id)
	{
		this.id = id;
	}
	public Contact(int id, string name, string email)
	{
		this.id = id;
		if (name.Length > MAXLENGTH)
			name = name.Substring(0, MAXLENGTH);
		if (email.Length > MAXLENGTH)
			email = email.Substring(0, MAXLENGTH);
		this.name = name;
		this.email = email;
	}
	public void ChangeId(int newId)
	{
		// the following will give a compiler error
		// id = newId;
	}
	public void ChangeName(string newName)
	{
		if (newName.Length > MAXLENGTH)
			newName = newName.Substring(0, MAXLENGTH);
		name = newName;
	}
	public void ChangeEmail(string newEmail)
	{
		if (newEmail.Length > MAXLENGTH)
			newEmail = newEmail.Substring(0, MAXLENGTH);
		email = newEmail;
	}
	public int GetId()
	{
		return id;
	}
	public string GetName()
	{
		return name;
	}
	public string GetEmail()
	{
		return email;
	}
}