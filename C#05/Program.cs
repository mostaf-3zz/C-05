namespace C_05
{
    internal class Program
    {

        public static void PassingByValue(int x)
        {
            int X = 100;
        }
        public static void PassingByRefence(ref int x)
        {
            int X = 100;
        }
        public static (int sum, int difference) Calculate(int a, int b, int c, int d)
        {
            int sum = a + b;
            int difference = c - d;
            return (sum, difference);
        }

        public static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
            }
            return sum;
        }
        public static bool IsPrime(int number)
        {

            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        public static void MinMaxArray(int[] array, ref int min, ref int max)
        {
            if (array.Length == 0)
                throw new ArgumentException("Array cannot be empty.");

            min = array[0];
            max = array[0];

            foreach (int number in array)
            {
                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }
        }
        static void Main(string[] args)
        {

            #region Q1 
            int A = 10;
            int B = 20;
            PassingByValue(A);
            Console.WriteLine($"Value of a after PassByValue: {A}");
            PassingByRefence(ref B);
            Console.WriteLine($"Value of a after PassByValue: {B}");
            #endregion
            #region q3  
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            int num4 = int.Parse(Console.ReadLine());
            var results = Calculate(num1, num2, num3, num4);
            Console.WriteLine($"Sum of first and second number: {results.sum}");
            Console.WriteLine($"Difference of third and fourth number: {results.difference}");
            #endregion
            #region q4
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int result = SumOfDigits(num);
            Console.WriteLine($"The sum of the digits of the number {num} is: {result}");
            #endregion
            #region q5 
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = IsPrime(num);
            if (isPrime)
                Console.WriteLine($"{num} is a prime number.");
            else
                Console.WriteLine($"{num} is not a prime number.");
            #endregion
            #region Q6 
            int[] numbers = { 3, 5, 7, 2, 8, -1, 4, 10, 12 };
            int min = 0;
            int max = 0;
            MinMaxArray(numbers, ref min, ref max);
            Console.WriteLine($"Minimum value in the array: {min}");
            Console.WriteLine($"Maximum value in the array: {max}");
            #endregion



        }
    }



}









