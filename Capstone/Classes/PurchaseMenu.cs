using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
	public class PurchaseMenu
	{
		public VendingMachine Vm { get; set; }

		public PurchaseMenu(VendingMachine vm)
		{
			this.Vm = vm;
		}

		public void Display()
		{
			while (true)
            {
                DisplayMenuOptions();

                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine().ToUpper();

                // Determines what menu the user will go to 
                if (input == "1")
                {
                    Console.WriteLine("Feed Money");
                    PaymentMenu paymentMenu = new PaymentMenu(this.Vm);
                    paymentMenu.Display();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Select Product");
                    SelectProductMenu selectProductMenu = new SelectProductMenu(this.Vm);
                    selectProductMenu.Display();
                }
                else if (input == "3")
                {
                    Console.WriteLine("Finish Transaction");
                    FinishTransactionMenu finishTransactionMenu = new FinishTransactionMenu(this.Vm);
                    finishTransactionMenu.Display();
                }
                else if (input == "Q")
                {
                    Console.WriteLine("Returning to main menu");
                    break;
                }

                // Asks the user to enter another input when they have entered an invalid one. 
                else
                {
                    Console.WriteLine("Please try again");
                }

            }
        }

        /// <summary>
        /// Display menu options 
        /// </summary>
        private static void DisplayMenuOptions()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Welcome to the Purchase Menu:");
            Console.WriteLine("1] >> Feed Money");
            Console.WriteLine("2] >> Select Product");
            Console.WriteLine("3] >> Finish Transaction");
            Console.WriteLine("Q] >> Return to Main Menu");
        }



    }
}
