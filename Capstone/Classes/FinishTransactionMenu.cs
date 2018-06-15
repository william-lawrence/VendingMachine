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
				Console.Clear();
				Console.WriteLine();
				Console.WriteLine("Welcome to the Purchase Menu:");
				Console.WriteLine("1] >> Finish Transaction");
				Console.WriteLine("Q] >> Return to Purchase Menu");

				Console.Write("What option do you want to select? ");
				string input = Console.ReadLine().ToUpper();

				if (input == "1")
				{
					Console.WriteLine("Thank you for your patronage, have a blessed day!");

					Vm.MakeChange();

					foreach (var item in Vm.Cart)
					{
						Console.WriteLine($"Here is Your: {item.ProductName} {item.MakeConsumptionSound()}");
					}

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

				else if (input == "Q")
				{
					Console.WriteLine("Returning to previous menu");
					break;
				}
				else
				{
					Console.WriteLine("Please try again");
				}

			}
		}


	}
}
