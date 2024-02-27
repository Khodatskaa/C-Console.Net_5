using System;

class Program
{
    static void Main()
    {
        // Task 1
        Console.WriteLine(MapSquare(5, '*'));

        // Task 2
        Console.WriteLine(IsPalindrome(1221));

        // Task 3
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };
        int[] resultArray = FilterArray(originalArray, filterArray);
        Console.WriteLine(string.Join(" ", resultArray));

        // Task 4
        Website website = new Website();
        website.InputData();
        website.OutputData();

        // Task 5
        Journal journal = new Journal();
        journal.InputData();
        journal.OutputData();

        // Task 6
        Store store = new Store();
        store.InputData();
        store.OutputData();
    }
}
