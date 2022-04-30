using System;

namespace Commercial_data_processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Admin\OneDrive\Desktop\Bridzlabs\Object oriented programming\CommertialDataProcessing\CommertialDtaProcessing\StocksFile.json";

            Console.WriteLine(" Welcome to Commercial_data_processing Stock_management Program");
            StockMain sm = new StockMain();
            sm.ReadJsonFile(filePath);
        }
    }
}
