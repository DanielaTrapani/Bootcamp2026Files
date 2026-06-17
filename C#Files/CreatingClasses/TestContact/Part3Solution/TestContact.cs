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
		cont = new Contact(33);
		cont.ChangeEmail("foo@bar.com");
		cont.ChangeName("John Doe");
		ShowContact(cont);
		// New contact with id = 77, name = "Jane Smith", email = "jane@smith.org"
		cont = new Contact(77, "Jane Smith", "jane@smith.org");
		ShowContact(cont);
		// Try to construct long name and email
		cont = new Contact(88, "Jonathan SomebodyWithALongName", "longemailaddress@somebusiness.com");
		ShowContact(cont);
		// Try to change to a long name and email
		cont.ChangeName("William ThisIsAnotherLongName");
		cont.ChangeEmail("thisisanotherlongemailaddress@any.com");
		ShowContact(cont);
		// Try to change the id
		cont.ChangeId(99);
	}
	private static void ShowContact(Contact cont)
	{
		Console.WriteLine("id = {0}, name = {1}, email = {2}",
			cont.GetId(), cont.GetName(), cont.GetEmail());
	}
}
