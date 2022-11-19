namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.Read();
            Console.WriteLine(CounterTwo(2, 8));
            MultiplicationTable(3);
        }

        public static bool CounterTwo(int a, int b)
        {
            var check = a == b ? true : false;

            return check;
        }





        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }


        public static void PrintRange(int ceiling, int floor)
        {
            for (int i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"thats definitely even");
            }
            else
            {
                Console.WriteLine($"thats definitely odd");
            }

        }

        public static bool IsPositive(int num1)
        {
            if (num1 > 0)
            {
                return true;
            }

            return false;

        }

        public static bool OfVotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"yes they can vote");
                return true;
            }
            else
            {
                Console.WriteLine($"No too young to vote by {18 - age} years");
                return false;
            }
        }

        public static bool IsTenRange(int num)
        {
            if (num <= 10 && num >= -10)
            {
                return true;
            }
            return false;
        }

        public static void MultiplicationTable(int num)
        {
            for (var i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} times {i} is {num * i}");
            }
        }
    }
}
