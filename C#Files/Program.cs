namespace DemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GenericList();
            GuessNumber();

            Console.ReadLine();
        }

        private static void GuessNumber()
        {
            // Random Number Guessing Game Ex
            Random rand = new Random();
            int secret = rand.Next(1, 11);   // Random number between 1 and 10
            int guess;

            Console.WriteLine("I'm thinking of a number between 1 and 10...");

            do
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());

                if (guess < secret)
                {
                    Console.WriteLine("Too low!");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("You got it!");
                }
            }
            while (guess != secret);
        }

        private static void GenericList()
        {
            List<decimal> salesTotals = new List<decimal>
    { 3275.68m, 4398.55m, 5289.75m, 1933.98m };

            salesTotals.Insert(0, 2745.73m);
            // insert new first element

            decimal sales1 = salesTotals[0];

            sales1 = salesTotals[0];         // sales1 = 2745.73
            decimal sales2 = salesTotals[1]; // sales2 = 3275.68

            salesTotals.RemoveAt(1);         // remove second element
            sales2 = salesTotals[1];         // sales2 = 4398.55

            Console.WriteLine($"{sales1}, {sales2}");

        }
    }
}
