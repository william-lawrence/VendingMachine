using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    /// <summary>
    /// Menu used to select product
    /// </summary>
	public class SelectProductMenu
    {
        public VendingMachine Vm { get; set; }

        public SelectProductMenu(VendingMachine vm)
        {
            this.Vm = vm;
        }

        public void Display()
        {
            while (true)
            {

                ShowAvailableItems();

                // Showing how much money the users have spend, and how much they have remaining.
                Console.WriteLine($"Total Money Input: {Vm.Balance.ToString("C2")}");
                Console.WriteLine($"Current total in cart: {Vm.FindTotalPrice().ToString("C2")}");

                // Putting all the individual vending machine items in a list so that their properties can be easily accessed. 
                List<VendingMachineItem> items = new List<VendingMachineItem>(Vm.Stock.Values);

                // Logger that will track transactions
                Logger logger = new Logger(Vm);

                Console.Write("What option do you want to select? (Press Q to quit)");
                string input = Console.ReadLine().ToUpper();

                // Path where the user has selected a valid item.
                if (input != "Q")
                {
                    //bool canPurchaseItem = Vm.Stock.ContainsKey(input) && Vm.Stock[input].Price <= Vm.Balance && Vm.Stock[input].Quantity > 0;
                    
                    foreach (var item in items)
                    {
                        // Path where the product exists, and the user has enough money to purchase it. 
                        bool canPurchaseItem = item.Price <= Vm.Balance && item.SlotLocation == input && item.Quantity > 0;
                        if (canPurchaseItem)
                        {
                            Vm.Cart.Add(item);
                            Vm.SubtractFromBalance(item.Price);
                            item.RemoveItem();
                            logger.LogVendItem(item);
                            break;
                        }
                        // Path where the product exists, but the user does not have enough money to purchase it.
                        else if (item.Price > Vm.Balance && item.SlotLocation == input && item.Quantity > 0)
                        {
                            Console.WriteLine($"You do not have enough money to purchase {item.ProductName}");
                            Console.Beep(440, 500);
                            System.Threading.Thread.Sleep(2000);
                            break;
                        }
                    }

                }
                // Path where the user chooses to leave this menu.
                else if (input == "Q")
                {
                    break;
                }
                // Path for invalid input.
                else
                {
                    Console.WriteLine("Please Try Again");
                }

            }
        }

        /// <summary>
        /// Shows all the products that are available in the vending machine.
        /// </summary>
        private void ShowAvailableItems()
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Available Products: ");

            foreach (var item in Vm.Stock.Values)
            {
                if (item.Quantity > 0)
                {
                    Console.WriteLine($"  {item.SlotLocation}  {item.ProductName}  {item.Price}");
                }

            }
        }



    }
}
