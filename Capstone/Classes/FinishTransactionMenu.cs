using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
	public class FinishTransactionMenu
	{
		public VendingMachine Vm { get; set; }

		public FinishTransactionMenu(VendingMachine vm)
		{
			this.Vm = vm;
		}

		public void Display()
		{
			while (true)
            {
                DisplayOptions();
                string input = Console.ReadLine().ToUpper();

                // Path where user decides to purchase items.
                if (input == "1")
                {
                    Console.WriteLine("Thank you for your patronage, have a blessed day!");

                    Vm.MakeChange();

                    // Loops through each item in the cart, displays item name and consumption sound.
                    foreach (var item in Vm.Cart)
                    {
                        Console.WriteLine($"Here is Your: {item.ProductName} {item.MakeConsumptionSound()}");
                    }

                    // Final menu
                    Console.WriteLine();
                    Console.WriteLine($"Press Q to return the previous menu.");
                    Console.WriteLine($"Press X to exit the program.");
                    input = Console.ReadLine().ToUpper();

                    if (input == "Q")
                    {
                        break;
                    }
                    else if (input == "X")
                    {
                        System.Environment.Exit(0);
                    }

                }
                // Path where user returns to previous menu.
                else if (input == "Q")
                {
                    Console.WriteLine("Returning to previous menu");
                    break;
                } 
                // Path where the user inputs an invalid string.
                else
                {
                    Console.WriteLine("Please try again");
                }

            }
        }

        private static void DisplayOptions()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Are you sure that you want to finish your purchase?: ");
            Console.WriteLine("1] >> Finish Transaction");
            Console.WriteLine("Q] >> Return to Purchase Menu");
            Console.Write("What option do you want to select? ");
        }

    }
}
