using System;

namespace Model
{
    // Task 1
    public static class ProductInRange
    {
        public static int ProductInRange(int start, int end)
        {
            int product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= i;
            }
            return product;
        }
    }

    // Task 2
    public static class IsFibonacci
    {
        public static bool IsFibonacci(int num)
        {
            int a = 0, b = 1;
            while (b < num)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b == num;
        }
    }

    // Task 3
    public static class SortArray
    {
        public static void SortArray(int[] array, bool ascending)
        {
            if (ascending)
            {
                Array.Sort(array);
            }
            else
            {
                Array.Sort(array);
                Array.Reverse(array);
            }
        }
    }

    // Task 4
    public class City
    {
        private string cityName;
        private string countryName;
        private int inhabitants;
        private string phoneCode;
        private string[] cityDistricts;

        public void InputData()
        {
            Console.Write("Enter City Name: ");
            cityName = Console.ReadLine();

            Console.Write("Enter Country Name: ");
            countryName = Console.ReadLine();

            Console.Write("Enter Number of Inhabitants: ");
            inhabitants = int.Parse(Console.ReadLine());

            Console.Write("Enter City Phone Code: ");
            phoneCode = Console.ReadLine();

            Console.Write("Enter City Districts (comma-separated): ");
            cityDistricts = Console.ReadLine().Split(',');
        }

        public void OutputData()
        {
            Console.WriteLine($"City: {cityName}, Country: {countryName}, Inhabitants: {inhabitants}, Phone Code: {phoneCode}");
            Console.WriteLine($"Districts: {string.Join(", ", cityDistricts)}");
        }
    }

    // Task 5
    public class Employee
    {
        private string name;
        private DateTime dateOfBirth;
        private string phoneNumber;
        private string email;
        private string position;
        private string duties;

        public void InputData()
        {
            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Date of Birth (YYYY-MM-DD): ");
            dateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Contact Phone Number: ");
            phoneNumber = Console.ReadLine();

            Console.Write("Enter Working Email: ");
            email = Console.ReadLine();

            Console.Write("Enter Position: ");
            position = Console.ReadLine();

            Console.Write("Enter Description of Official Duties: ");
            duties = Console.ReadLine();
        }

        public void OutputData()
        {
            Console.WriteLine($"Name: {name}, DOB: {dateOfBirth.ToShortDateString()}, Phone: {phoneNumber}, Email: {email}");
            Console.WriteLine($"Position: {position}, Duties: {duties}");
        }
    }

    // Task 6
    public class Aircraft
    {
        private string aircraftName;
        private string manufacturerName;
        private int yearOfManufacture;
        private string aircraftType;

        public void InputData()
        {
            Console.Write("Enter Aircraft Name: ");
            aircraftName = Console.ReadLine();

            Console.Write("Enter Manufacturer's Name: ");
            manufacturerName = Console.ReadLine();

            Console.Write("Enter Year of Manufacture: ");
            yearOfManufacture = int.Parse(Console.ReadLine());

            Console.Write("Enter Aircraft Type: ");
            aircraftType = Console.ReadLine();
        }

        public void OutputData()
        {
            Console.WriteLine($"Aircraft: {aircraftName}, Manufacturer: {manufacturerName}, Year: {yearOfManufacture}, Type: {aircraftType}");
        }
    }

    // Task 7
    public class Matrix
    {
        private int[,] matrix;

        public void InputData()
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            matrix = new int[rows, columns];

            Console.WriteLine("Enter matrix elements:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Matrix[{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void OutputData()
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        public int GetMax()
        {
            int max = matrix[0, 0];
            foreach (int element in matrix)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        public int GetMin()
        {
            int min = matrix[0, 0];
            foreach (int element in matrix)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }
    }
}
