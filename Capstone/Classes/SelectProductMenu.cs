using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
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
				
				Console.WriteLine();
				Console.WriteLine("Welcome to the Product Selection Menu:");
				Console.WriteLine("A1] >> Feed Money");
				Console.WriteLine("2] >> Select Product");
				Console.WriteLine("3] >> Finish Transaction");
				Console.WriteLine("Q] >> Return to Main Menu");

				Console.Write("What option do you want to select? ");
				string input = Console.ReadLine().ToUpper();

				if (input == "A1")
				{
					Console.WriteLine($"{Vm.Stock.Values.ToString()}");
					

				}
				else if (input == "A2")
				{
					Console.WriteLine("Select Product");
				}
				else if (input == "A3")
				{
					Console.WriteLine("Finish Transaction");
				}
				else if (input == "A4")
				{
					Console.WriteLine("Finish Transaction");
				}
				if (input == "B1")
				{
					Console.WriteLine("Feed Money");
					
				}
				else if (input == "B2")
				{
					Console.WriteLine("Select Product");
				}
				else if (input == "B3")
				{
					Console.WriteLine("Finish Transaction");
				}
				else if (input == "B4")
				{
					Console.WriteLine("Finish Transaction");
				}
				if (input == "C1")
				{
					Console.WriteLine("Feed Money");
				
				}
				else if (input == "C2")
				{
					Console.WriteLine("Select Product");
				}
				else if (input == "C3")
				{
					Console.WriteLine("Finish Transaction");
				}
				else if (input == "C4")
				{
					Console.WriteLine("Finish Transaction");
				}
				if (input == "D1")
				{
					Console.WriteLine("Feed Money");
				
				}
				else if (input == "D2")
				{
					Console.WriteLine("Select Product");
				}
				else if (input == "D3")
				{
					Console.WriteLine("Finish Transaction");
				}
				else if (input == "D4")
				{
					Console.WriteLine("Finish Transaction");
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
