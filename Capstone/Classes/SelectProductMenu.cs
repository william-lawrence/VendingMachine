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

				Console.WriteLine($"Total Money Input: {Vm.Balance.ToString("C2")}");
				Console.WriteLine($"Current total in cart: {Vm.FindTotalPrice().ToString("C2")}");

				List<VendingMachineItem> items = new List<VendingMachineItem>(Vm.Stock.Values);
				Logger logger = new Logger(Vm);

				Console.Write("What option do you want to select? (Press Q to quit)");
				string input = Console.ReadLine().ToUpper();
				if (input != "Q")
				{


					foreach (var item in items)
					{
						if (item.Price <= Vm.Balance && item.SlotLocation == input && item.Quantity > 0)
						{

							Vm.Cart.Add(item);
							Vm.TotalPrice += item.Price;
							Vm.SubtractFromBalance(item.Price);
							item.RemoveItem();
							logger.LogVendItem(item);
							break;
						}
						else if (item.Price > Vm.Balance && item.SlotLocation == input && item.Quantity > 0)
						{
							Console.WriteLine($"You do not have enough money to purchase {item.ProductName}");
							Console.Beep(440, 500);
							System.Threading.Thread.Sleep(2000);
							break;
						}
					}

				}
				else if (input == "Q")
				{
					break;
				}
				else
				{
					Console.WriteLine("Please Try Again");
				}

			}
		}




	}
}
