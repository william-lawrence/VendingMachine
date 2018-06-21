using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    /// <summary>
    /// The main menu of the application.
    /// </summary>
	public class MainMenu
    {
        public VendingMachine Vm { get; set; }
        public MainMenu(VendingMachine vm)
        {
            this.Vm = vm;
        }

        /// <summary>
        /// Displays the main menu.
        /// </summary>
		public void Display()
        {
            PrintHeader();

            while (true)
            {
                DisplayMenuOptions();

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine().ToUpper();

                // Displays all items and their price to the user.
                if (input == "1")
                {
                    ItemDisplay items = new ItemDisplay(this.Vm);
                    items.Display();
                }
                // Takes the user to the purchase menu.
                else if (input == "2")
                {
                    PurchaseMenu purchase = new PurchaseMenu(this.Vm);
                    purchase.Display();
                }
                // Exits the program.
                else if (input == "Q" || input == "q")
                {
                    Console.WriteLine("Quitting");
                    break;
                }
                // Asks the user to try again if they entered an invalid input.
                else
                {
                    Console.WriteLine("Please try again");
                }
            }
        }

        /// <summary>
        /// Displays the menu options.
        /// </summary>
        private void DisplayMenuOptions()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1] >> Display Vending Machine Items");
            Console.WriteLine("2] >> Purchase");
            Console.WriteLine("Q] >> Quit");
            Console.WriteLine($"Current Money Provided: {Vm.Balance.ToString("C2")}");
        }

        /// <summary>
        /// Prints header to console.
        /// </summary>
        private void PrintHeader()
        {
            Console.WriteLine("WELCOME!!!!");
        }
    }




}

