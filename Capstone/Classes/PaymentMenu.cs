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
				Console.WriteLine();
				Console.WriteLine("Pick an Amount:");
				Console.WriteLine("1] >> $ 1.00");
				Console.WriteLine("2] >> $ 2.00");
				Console.WriteLine("3] >> $ 5.00");
				Console.WriteLine("4] >> $ 10.00");
				Console.WriteLine("Q] >> Return to Main Menu");

				Console.Write("What option do you want to select? ");
				string input = Console.ReadLine();

				if (input == "1")
				{
					Vm.Add1();
					Console.WriteLine($"Balance: {Vm.Balance}");
				}
				else if (input == "2")
				{
					Vm.Add2();
					Console.WriteLine($"Balance: {Vm.Balance}");
				}
				else if (input == "3")
				{
					Vm.Add5();
					Console.WriteLine($"Balance: {Vm.Balance}");
				}
				else if (input == "4")
				{
					Vm.Add10();
					Console.WriteLine($"Balance: {Vm.Balance}");
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


	}
}
