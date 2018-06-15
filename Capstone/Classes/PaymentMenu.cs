using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class PaymentMenu
    {
        public VendingMachine Vm { get; set; }
        public PaymentMenu(VendingMachine vm)
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
                Logger logger = new Logger(Vm);

                // Determines the amount of money to be added to Vm.Balance.
                if (input == "1")
                {
                    Vm.Add1();
                    logger.LogFeedMoney(1.00M);
                }
                else if (input == "2")
                {
                    Vm.Add2();
                    logger.LogFeedMoney(2.00M);
                }
                else if (input == "3")
                {
                    Vm.Add5();
                    logger.LogFeedMoney(5.00M);
                }
                else if (input == "4")
                {
                    Vm.Add10();
                    logger.LogFeedMoney(10.00M);
                }
                else if (input == "Q")
                {
                    Console.WriteLine("Returning to main menu");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }

            }
        }

        /// <summary>
        /// Displays the menu options
        /// </summary>
        private void DisplayMenuOptions()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"Current Balance: {Vm.Balance.ToString("C2")}");
            Console.WriteLine("Pick an Amount:");
            Console.WriteLine("1] >> $ 1.00");
            Console.WriteLine("2] >> $ 2.00");
            Console.WriteLine("3] >> $ 5.00");
            Console.WriteLine("4] >> $ 10.00");
            Console.WriteLine("Q] >> Return to Purchase Menu");
        }
    }
}
