using System;

class Model
{
    // Task 1
    static string MapSquare(int sideLength, char symbol)
    {
        string square = "";
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                square += symbol + " ";
            }
            square += "\n";
        }
        return square;
    }

    // Task 2
    static bool IsPalindrome(int number)
    {
        string numStr = number.ToString();
        int length = numStr.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (numStr[i] != numStr[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    // Task 3
    static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        return Array.FindAll(originalArray, element => Array.IndexOf(filterArray, element) == -1);
    }

    // Task 4
    class Website
    {
        private string siteName;
        private string sitePath;
        private string siteDescription;
        private string siteIpAddress;

        public void InputData()
        {
            Console.Write("Enter Site Name: ");
            siteName = Console.ReadLine();

            Console.Write("Enter Site Path: ");
            sitePath = Console.ReadLine();

            Console.Write("Enter Site Description: ");
            siteDescription = Console.ReadLine();

            Console.Write("Enter Site IP Address: ");
            siteIpAddress = Console.ReadLine();
        }

        public void OutputData()
        {
            Console.WriteLine($"Site Name: {siteName}, Path: {sitePath}, Description: {siteDescription}, IP Address: {siteIpAddress}");
        }
    }

    // Task 5
    class Journal
    {
        private string journalName;
        private int yearOfFoundation;
        private string journalDescription;
        private string contactPhoneNumber;
        private string email;

        public void InputData()
        {
            Console.Write("Enter Journal Name: ");
            journalName = Console.ReadLine();

            Console.Write("Enter Year of Foundation: ");
            yearOfFoundation = int.Parse(Console.ReadLine());

            Console.Write("Enter Journal Description: ");
            journalDescription = Console.ReadLine();

            Console.Write("Enter Contact Phone Number: ");
            contactPhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            email = Console.ReadLine();
        }

        public void OutputData()
        {
            Console.WriteLine($"Journal Name: {journalName}, Year of Foundation: {yearOfFoundation}, Description: {journalDescription}");
            Console.WriteLine($"Contact Phone Number: {contactPhoneNumber}, Email: {email}");
        }
    }

    // Task 6
    class Store
    {
        private string storeName;
        private string address;
        private string storeProfileDescription;
        private string contactPhoneNumber;
        private string email;

        public void InputData()
        {
            Console.Write("Enter Store Name: ");
            storeName = Console.ReadLine();

            Console.Write("Enter Address: ");
            address = Console.ReadLine();

            Console.Write("Enter Store Profile Description: ");
            storeProfileDescription = Console.ReadLine();

            Console.Write("Enter Contact Phone Number: ");
            contactPhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            email = Console.ReadLine();
        }

        public void OutputData()
        {
            Console.WriteLine($"Store Name: {storeName}, Address: {address}, Profile Description: {storeProfileDescription}");
            Console.WriteLine($"Contact Phone Number: {contactPhoneNumber}, Email: {email}");
        }
    }

}

