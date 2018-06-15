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
				Console.WriteLine("Available Products: ");

				foreach (var item in Vm.Stock.Values)
				{
					Console.WriteLine($"  {item.SlotLocation}  {item.ProductName}  {item.Price}");
				}

				List<VendingMachineItem> items = new List<VendingMachineItem>(Vm.Stock.Values);

				Console.Write("What option do you want to select? ");
				string input = Console.ReadLine().ToUpper();

				foreach (var item in items)
				{
					if (item.SlotLocation == input && item.Quantity > 0)
					{
						Vm.Cart.Add(item);
						Vm.TotalPrice += item.Price;
						item.RemoveItem();
					}
				}

			}
		}




	}
}
