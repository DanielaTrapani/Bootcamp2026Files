namespace IfLoopExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeapYear();
            //LeapYearLoop();
            //ShowCapital();

        }

        private static void ShowCapital()
        {
            Console.WriteLine("Enter a two letter state code to learn its capital.");
            string state = Console.ReadLine();
            state = state.ToUpper();


            string capital;  // variable to hold the answer

            switch (state)
            {
                case "NC":
                    capital = "Raleigh";
                    break;
                case "FL":
                    capital = "Tallahassee";
                    break;
                case "OH":
                    capital = "Columbus";
                    break;
                case "MI":
                    capital = "Lansing";
                    break;
                default:
                    capital = "I don't know!";
                    break;
            }

            Console.WriteLine($"The capital of {state} is {capital}.");
            Console.ReadLine();
        }

        private static void LeapYear()
        {
            Console.Write("Enter year: ");
            string buf = Console.ReadLine();
            int year = Convert.ToInt32(buf);

            if ((year % 4 == 0) &&
              ((year % 400 == 0) || (year % 100 != 0)))
                Console.WriteLine("{0} is a leap year", year);
            else
                Console.WriteLine("{0} is not a leap year", year);


            Console.ReadLine();
        }

        private static void LeapYearLoop()
        {
            Console.WriteLine("Enter -1 to terminate the program");
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            while (year != -1)
            {
                if ((year % 4 == 0) &&
                    ((year % 400 == 0) || (year % 100 != 0)))
                {
                    Console.WriteLine("{0} is a leap year", year);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year", year);
                }
                Console.Write("Enter another year: ");
                year = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
