﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
	public class MainMenu
	{
		public VendingMachine Vm { get; set; }
		public MainMenu(VendingMachine vm)
		{
			this.Vm = vm;
		}



		public void Display()
		{
			PrintHeader();

			while (true)
			{
				Console.WriteLine();
				Console.WriteLine("Main Menu");
				Console.WriteLine("1] >> Display Vending Machine Items");
				Console.WriteLine("2] >> Purchase");
				Console.WriteLine("Q] >> Quit");

				Console.Write("What option do you want to select? ");
				string input = Console.ReadLine();

				if (input == "1")
				{
					Console.WriteLine("Available Items: ");
					foreach (var item in Vm.Stock)
					{

					}
				}
				else if (input == "2")
				{
					PurchaseMenu purchase = new PurchaseMenu(this.Vm);
					purchase.Display();
				}
				else if (input == "Q")
				{
					Console.WriteLine("Quitting");
					break;
				}
				else
				{
					Console.WriteLine("Please try again");
				}
			}
		}

		private void PrintHeader()
		{

			Console.WriteLine("WELCOME!!!!");
		}
	}




}

