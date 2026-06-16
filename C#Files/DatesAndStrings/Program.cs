using System.Text;

namespace DatesAndStringsExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateParsingAndValidation();
            //IsWeekend();
            //DaysUntilDue();
            //AddSpaces();
            //ExtractFirstName();
            //ParseAddress();
            //FormatNumberAndDate();
            //UseStringBuilder();
            //ReplaceHypens();
            //CustomDate();

        }

        private static void CustomDate()
        {
            DateTime today = DateTime.Now;

            string formatted = String.Format("{0:ddd, MMM d, yyyy}", today);

            Console.WriteLine(formatted);

            Console.ReadLine();
        }

        private static void ReplaceHypens()
        {
            string date = "12-27-2022";

            if (!String.IsNullOrEmpty(date))
            {
                date = date.Replace("-", "/");
            }

            Console.WriteLine(date);

            Console.ReadLine();
        }

        private static void UseStringBuilder()
        {
            StringBuilder phone = new StringBuilder("9195551212");

            phone.Insert(3, "-");
            phone.Insert(7, "-");

            Console.WriteLine(phone.ToString());

            Console.ReadLine();
        }

        private static void FormatNumberAndDate()
        {
            decimal amount = 987.65m;
            DateTime due = new DateTime(2025, 5, 15);

            Console.WriteLine($"{amount:c} due on {due:d}.");

            Console.ReadLine();
        }

        private static void ParseAddress()
        {
            string address = "|805 Main Street|Dallas|TX|12345|";

            address = address.Trim();

            if (address.StartsWith("|"))
            {
                address = address.Remove(0, 1);
            }

            if (address.EndsWith("|"))
            {
                address = address.Remove(address.Length - 1, 1);
            }

            string[] parts = address.Split('|');

            string street = parts[0];
            string city = parts[1];
            string state = parts[2];
            string zip = parts[3];

            Console.WriteLine(street);
            Console.WriteLine(city);
            Console.WriteLine(state);
            Console.WriteLine(zip);

            Console.ReadLine();
        }

        private static void ExtractFirstName()
        {
            Console.Write("Enter full name: ");
            string fullName = Console.ReadLine();

            fullName = fullName.Trim();
            int firstSpace = fullName.IndexOf(" ");

            string firstName;

            if (firstSpace == -1)
            {
                firstName = fullName;
            }
            else
            {
                firstName = fullName.Substring(0, firstSpace);
            }

            Console.WriteLine($"First name: {firstName}");

            Console.ReadLine();
        }

        static void AddSpaces()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string hellowithspaces = "";

            for (int i = 0; i < input.Length; i++)
            {
                hellowithspaces += input[i] + " ";
            }

            Console.WriteLine(hellowithspaces.Trim());

            Console.ReadLine();
        }

      

        private static void DaysUntilDue()
        {
            Console.Write("Enter due date: ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;

            if (today > dueDate)
            {
                Console.WriteLine("Past due.");
            }
            else
            {
                TimeSpan span = dueDate - today;
                Console.WriteLine($"Days until due: {span.Days}");
            }

            Console.ReadLine();
        }

        private static void IsWeekend()
        {
            Console.Write("Enter a date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            DayOfWeek day = date.DayOfWeek;

            if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Weekday");
            }

            Console.ReadLine();
        }

        private static void DateParsingAndValidation()
        {
            Console.Write("Enter a date: ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime date))
            {
                Console.WriteLine($"Long date: {date.ToLongDateString()}");
                Console.WriteLine($"Short time: {date.ToShortTimeString()}");
            }
            else
            {
                Console.WriteLine("Invalid date. Please try again.");
            }

            Console.ReadLine();
        }
    }
}
