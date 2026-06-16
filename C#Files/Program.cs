namespace BasicExceptionLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 2
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            try
            {
                decimal number = Convert.ToDecimal(input);
                Console.WriteLine($"Number entered: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format error: Enter a valid number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow: Enter a smaller number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().ToString());
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();
           
        }
    }
}
