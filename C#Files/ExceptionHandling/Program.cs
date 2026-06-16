namespace ExceptionValidationLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Monthly investment: ");
            string inv = Console.ReadLine();

            Console.Write("Interest rate: ");
            string rate = Console.ReadLine();

            Console.Write("Years: ");
            string years = Console.ReadLine();

            string message = "";
            message += IsPresent(inv, "Monthly Investment");
            message += IsPresent(rate, "Interest Rate");
            message += IsPresent(years, "Years");

            message += IsDecimal(inv, "Monthly Investment");
            message += IsDecimal(rate, "Interest Rate");
            message += IsDecimal(years, "Years");

            message += IsWithinRange(inv, "Monthly Investment", 1, 1000);
            message += IsWithinRange(rate, "Interest Rate", .1m, 20m);
            message += IsWithinRange(years, "Years", 1, 40);

            if (message != "")
            {
                Console.WriteLine(message);
            }
            else
            {
                decimal fv = CalculateFutureValue(
                    Convert.ToDecimal(inv),
                    Convert.ToDecimal(rate) / 12 / 100,
                    Convert.ToInt32(years) * 12);

                Console.WriteLine($"Future Value: {fv}");
            }

            Console.ReadLine();
        }

        static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyRate, int months)
        {
            if (monthlyInvestment <= 0)
                throw new Exception("Monthly Investment must be greater than 0.");

            if (monthlyRate <= 0)
                throw new Exception("Interest Rate must be greater than 0.");

            decimal futureValue = 0m;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyRate);
            }

            return futureValue;
        }

        static string IsPresent(string value, string name)
        {
            if (value == "")
                return $"{name} is a required field.\n";

            return "";
        }

        static string IsDecimal(string value, string name)
        {
            if (!Decimal.TryParse(value, out _))
                return $"{name} must be a valid decimal value.\n";

            return "";
        }

        static string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                    return $"{name} must be between {min} and {max}.\n";
            }

            return "";
        }






    }
}
