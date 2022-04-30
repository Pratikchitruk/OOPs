using System;

namespace StockManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Admin\OneDrive\Desktop\Bridzlabs\Object oriented programming\StockAccountManagnent\StocksFile.json";

            Console.WriteLine(" Welcome to Stock account Management system \n");
            StockMain sm = new StockMain();
            sm.ReadJsonFile(filePath);
        }
    }
}