using System;

class Program
{
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
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        return array;
    }
}
