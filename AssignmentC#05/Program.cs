namespace AssignmentC_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //int valueParameter = 10;
            //int referenceParameter = 10;

            //Console.WriteLine($"Value Parameter: {valueParameter}");
            //Console.WriteLine($"Reference Parameter: {referenceParameter}");

            //PassByValue(valueParameter);
            //PassByReference(ref referenceParameter);

            //Console.WriteLine("-----------------------------------------------------");
            //Console.WriteLine($"Value Parameter: {valueParameter}");         // Still 10
            //Console.WriteLine($"Reference Parameter: {referenceParameter}"); // Changed to 20
            #endregion
            #region  Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //int[] arrayParameter = { 3, 1, 2 };

            //Console.WriteLine("Before method call:");
            //Console.WriteLine($"Array Parameter: {string.Join(", ", arrayParameter)}");

            //SortArrayByValue(arrayParameter);
            //Console.WriteLine("After SortArrayByValue:");
            //Console.WriteLine($"Array : {string.Join(", ", arrayParameter)}");

            //Console.WriteLine("After CreateNewArray:");
            //Console.WriteLine($"Array : {string.Join(", ", arrayParameter)}");
            #endregion
            #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int sumResult;
            //int subtractResult;

            //Console.Write("Enter the first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Calculate(num1, num2, out sumResult, out subtractResult);

            //Console.WriteLine($"Sum: {sumResult}");
            //Console.WriteLine($"Difference: {subtractResult}");
            #endregion
            #region Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //int sumOfDigits = CalculateSumOfDigits(number);

            //Console.WriteLine($"The sum of the digits of the number {number} is: {sumOfDigits}");
            #endregion
            #region  Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //bool isPrime = IsPrime(number);

            //if (isPrime)
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}
            #endregion
            #region Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] numbers = { 5, 2, 9, 1, 5, 6 };

            //int minValue;
            //int maxValue;

            //MinMaxArray(numbers, out minValue, out maxValue);

            //Console.WriteLine($"Minimum value: {minValue}");
            //Console.WriteLine($"Maximum value: {maxValue}");
            #endregion
            #region  Create an iterative (non-recursive) function to calculate the factorial of the number specified as paramete
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //long factorial = CalculateFactorial(number);

            //Console.WriteLine($"The factorial of {number} is: {factorial}");
            #endregion
            #region Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //string originalString = "hello";
            //int position = 1;
            //char newChar = 'a';

            //string modifiedString = ChangeChar(originalString, position, newChar);

            //Console.WriteLine($"Original string: {originalString}");
            //Console.WriteLine($"Modified string: {modifiedString}");
            #endregion

        }
        static void PassByValue(int valueParam)
        {
            valueParam = 20;
        }

        static void PassByReference(ref int referenceParam)
        {
            referenceParam = 20;
        }

        static void SortArrayByValue(int[] arrayParam)
        {
            Array.Sort(arrayParam);
        }

        static void CreateNewArray(ref int[] arrayParam)
        {
            arrayParam = new int[] { 30, 10, 20 };
            Array.Sort(arrayParam);
        }

        static void Calculate(int a, int b, out int sum, out int difference)
        {
            sum = a + b;
            difference = a - b;
        }

        static int CalculateSumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void MinMaxArray(int[] arr, out int min, out int max)
        {
            min = arr[0];
            max = arr[0];

            foreach (int num in arr)
            {
                if (num < min)
                {
                    min = num;
                }

                if (num > max)
                {
                    max = num;
                }
            }
        }

        static long CalculateFactorial(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            long result = 1;

            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
        static string ChangeChar(string input, int position, char newChar)
        {
            if (position < 0 || position >= input.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range.");
            }

            char[] charArray = input.ToCharArray();

            charArray[position] = newChar;

            return new string(charArray);
        }
    }
}
