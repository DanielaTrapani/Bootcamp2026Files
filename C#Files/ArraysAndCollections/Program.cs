using System.Collections;

namespace ArraysAndCollectionsExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1_OneDimensionalArrays();
            Part2_RectangularArrays();
            Part3_ArrayOperations();
            Part4_Lists();
            Part5_SortedList();
            Part6_QueueStack();
            Part7_ArrayList();

            Console.ReadLine();
        }

        private static void Part7_ArrayList()
        {
            // Step 14
            ArrayList salesTotalsAL = new ArrayList
            {
                3275.68m, 4398.55m, 5289.75m, 1933.98m
            };

            salesTotalsAL.Insert(0, 2745.73m);
            salesTotalsAL.RemoveAt(1);

            foreach (decimal d in salesTotalsAL)
            {
                Console.WriteLine(d);
            }
        }

        private static void Part6_QueueStack()
        {
            // Step 12
            Queue<string> nameQueue = new Queue<string>();

            nameQueue.Enqueue("Boehm");
            nameQueue.Enqueue("Taylor");
            nameQueue.Enqueue("Murach");

            while (nameQueue.Count > 0)
            {
                Console.WriteLine(nameQueue.Dequeue());
            }

            // Step 13
            Stack<string> nameStack = new Stack<string>();

            nameStack.Push("Boehm");
            nameStack.Push("Taylor");
            nameStack.Push("Murach");

            while (nameStack.Count > 0)
            {
                Console.WriteLine(nameStack.Pop());
            }

        }

        private static void Part5_SortedList()
        {
            // Step 10
            SortedList<string, decimal> salesList = new SortedList<string, decimal>
            {
                { "FinkleP", 4398.55m },
                { "AdamsA", 3275.68m },
                { "PotterE", 1933.98m },
                { "LewisJ", 5289.75m }
            };

            foreach (KeyValuePair<string, decimal> entry in salesList)
            {
                Console.WriteLine(entry.Key + "\t" + entry.Value);
            }

            // Step 11
            Console.Write("Enter employee ID: ");
            string key = Console.ReadLine();

            if (salesList.ContainsKey(key))
            {
                Console.WriteLine($"Sales total: {salesList[key]}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }

        }

        private static void Part4_Lists()
        {
            // Step 8
            List<decimal> salesTotals = new List<decimal>
            {
                3275.68m, 4398.55m, 5289.75m, 1933.98m
            };

            salesTotals.Insert(0, 2745.73m);
            salesTotals.RemoveAt(1);

            foreach (decimal d in salesTotals)
            {
                Console.WriteLine(d);
            }

            // Step 9
            decimal valueToRemove = 2745.73m;

            if (salesTotals.Contains(valueToRemove))
            {
                salesTotals.Remove(valueToRemove);
            }

            foreach (decimal d in salesTotals)
            {
                Console.WriteLine(d);
            }


        }

        private static void Part3_ArrayOperations()
        {
            //Step 6
            string[] lastNames = { "Boehm", "Taylor", "Murach" };

            Array.Sort(lastNames);

            foreach (string name in lastNames)
            {
                Console.WriteLine(name);
            }

            //Step 7
            double[] inches = { 1, 2, 3 };
            double[] centimeters = new double[3];

            Array.Copy(inches, centimeters, inches.Length);

            for (int i = 0; i < centimeters.Length; i++)
            {
                centimeters[i] *= 2.54;
                Console.WriteLine(centimeters[i]);
            }


        }

        private static void Part2_RectangularArrays()
        {
            // Step 5
            int[,] numbers = new int[3, 2];

            numbers[0, 0] = 1;
            numbers[0, 1] = 2;
            numbers[1, 0] = 3;
            numbers[1, 1] = 4;
            numbers[2, 0] = 5;
            numbers[2, 1] = 6;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Part1_OneDimensionalArrays()
        {
            // Step 2
            decimal[] totals = new decimal[4];

            totals[0] = 14.95m;
            totals[1] = 12.95m;
            totals[2] = 11.95m;
            totals[3] = 9.95m;

            for (int i = 0; i < totals.Length; i++)
            {
                Console.WriteLine(totals[i]);
            }

            // Step 3
            decimal sum = 0m;

            for (int i = 0; i < totals.Length; i++)
            {
                sum += totals[i];
            }

            decimal average = sum / totals.Length;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");

            // Step 4
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();


        }
    }
}
