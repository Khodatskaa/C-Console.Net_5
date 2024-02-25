using System;

class Model
{
    // Task 1
    public static long GetProductInRange(int start, int end)
    {
        long product = 1;
        for (int i = start; i <= end; i++)
        {
            product *= i;
        }
        return product;
    }

    // Task 2
    public static bool IsPerfectSquare(int num)
    {
        int sqrt = (int)Math.Sqrt(num);
        return sqrt * sqrt == num;
    }

    public static bool IsFibonacciNumber(int num)
    {
        return IsPerfectSquare(5 * num * num + 4) || IsPerfectSquare(5 * num * num - 4);
    }

    // Task 3
    public enum SortOrder
    {
        Ascending,
        Descending
    }

    public static void SortArray(int[] array, SortOrder sortOrder)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if ((sortOrder == SortOrder.Ascending && array[j] > array[j + 1]) ||
                    (sortOrder == SortOrder.Descending && array[j] < array[j + 1]))
                {
                    // Swap array[j] and array[j+1]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
