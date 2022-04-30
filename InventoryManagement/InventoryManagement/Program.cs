using JsonOOPS.InventoryManagement;
using System;

namespace JsonOOPS
{
    class Program
    {
        const string INVENTORY_JSON = @"C:\Users\Admin\OneDrive\Desktop\Bridzlabs\Object oriented programming\InventoryManagement\InventoryManagement\Inventory.json";
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Json Inventory management program ");
            InventoryMain inv = new InventoryMain();
            inv.ShowOptions(INVENTORY_JSON);
        }
    }
}
