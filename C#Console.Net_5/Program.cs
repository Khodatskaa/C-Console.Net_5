using System;

class Program
{
    static void Main()
    {
        // Task 1
        Console.WriteLine(Model.ProductInRange(1, 5)); // Example range: 1 to 5

        // Task 2
        Console.WriteLine(Model.IsFibonacci(13)); // Example number: 13

        // Task 3
        int[] arrayToSort = { 5, 2, 8, 1, 3 };
        Model.SortArray(arrayToSort, Model.SortOrder.Ascending);
        Console.WriteLine(string.Join(", ", arrayToSort));

        // Task 4
        Model.City city = new Model.City();
        city.InputData();
        city.OutputData();

        // Task 5
        Model.Employee employee = new Model.Employee();
        employee.InputData();
        employee.OutputData();

        // Task 6
        Model.Aircraft aircraft = new Model.Aircraft();
        aircraft.InputData();
        aircraft.OutputData();

        // Task 7
        Model.Matrix matrix = new Model.Matrix();
        matrix.InputData();
        matrix.OutputData();
        Console.WriteLine($"Maximum: {matrix.GetMax()}, Minimum: {matrix.GetMin()}");
    }
}
