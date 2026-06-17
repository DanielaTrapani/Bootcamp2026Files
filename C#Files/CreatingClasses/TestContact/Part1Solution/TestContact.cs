// TestContact.cs

using System;

public class TestContact
{
	public static void Main()
	{
		Contact cont; 
		// New contact with default values
 		cont = new Contact();
		ShowContact(cont);
		// New contact with id = 33, name = "John Doe", email = "foo@bar.com"
		cont.ChangeId(33);
		cont.ChangeEmail("foo@bar.com");
		cont.ChangeName("John Doe");
		ShowContact(cont);
	}
	private static void ShowContact(Contact cont)
	{
		Console.WriteLine("id = {0}, name = {1}, email = {2}",
			cont.GetId(), cont.GetName(), cont.GetEmail());
	}
}
