using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    /// <summary>
    /// Display used to show the item and their name.
    /// </summary>
    public class ItemDisplay
    {
        public VendingMachine Vm { get; get; }

        public ItemDisplay(VendingMachine vm)
        {
            this.Vm = vm;
        }

        public void Display()
        {
            while (true)
            {
                ShowAvailableItems();

                string input = Console.ReadLine().ToUpper();

                if (input == "Q")
                {
                    Console.WriteLine("Returning to main menu");
                    break;
                }
                // Path if the user enters an in valid input.
                else
                {
                    Console.WriteLine("Please try again");
                }

            }
        }

        private void ShowAvailableItems()
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Available Items: ");
            foreach (var item in Vm.Stock.Values)
            {
                if (item.Quantity > 0)
                {
                    Console.WriteLine($"  {item.SlotLocation}  {item.ProductName}  {item.Price}");
                }
            }
            Console.Write("Enter Q to Quit: ");
        }
    }
}
