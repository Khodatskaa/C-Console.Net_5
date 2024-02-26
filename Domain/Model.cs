using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int start = 2;
        int end = 5;
        long result = GetProductInRange(start, end);
        Console.WriteLine($"Task 1: Product of numbers from {start} to {end} is: {result}");

        int numberToCheck = 21;
        bool isFibonacci = IsFibonacci(numberToCheck);
        Console.WriteLine($"Task 2: {numberToCheck} is a Fibonacci number: {isFibonacci}");

        int[] array = { 5, 2, 8, 1, 7 };
        Console.WriteLine("Task 3: Original Array: " + string.Join(", ", array));

        int[] sortedArrayAscending = CustomSort(array, sortOrder: "Ascending");
        Console.WriteLine("Task 3: Sorted Array (Ascending): " + string.Join(", ", sortedArrayAscending));

        int[] sortedArrayDescending = CustomSort(array, sortOrder: "Descending");
        Console.WriteLine("Task 3: Sorted Array (Descending): " + string.Join(", ", sortedArrayDescending));
    }

    // Task 1
    static long GetProductInRange(int start, int end)
    {
        long product = 1;

        for (int i = start; i <= end; i++)
        {
            product *= i;
        }

        return product;
    }

    // Task 2
    static bool IsPerfectSquare(int x)
    {
        int sqrt = (int)Math.Sqrt(x);
        return sqrt * sqrt == x;
    }

    static bool IsFibonacci(int number)
    {
        return IsPerfectSquare(5 * number * number + 4) || IsPerfectSquare(5 * number * number - 4);
    }

    // Task 3
    static int[] CustomSort(int[] array, string sortOrder)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                bool swapCondition = (sortOrder == "Ascending" && array[j] > array[j + 1]) ||
                                      (sortOrder == "Descending" && array[j] < array[j + 1]);

                if (swapCondition)
                {
                    // Swap elements
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        return array;
    }
}
