using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
	public class VendingMachine
	{
		public Dictionary<string, VendingMachineItem> Stock { get; private set; }
		public decimal Balance { get; private set; }
		public List<VendingMachineItem> Cart { get; private set; }



		private Stocker stocker = new Stocker();
		public VendingMachine()
		{
			Stock = new Dictionary<string, VendingMachineItem>(stocker.Inventory);
			Cart = new List<VendingMachineItem>();
			Balance = 0;
			
		}

		public decimal FindTotalPrice()
		{
			decimal totalPrice = 0;

			foreach (var item in this.Cart)
			{
				totalPrice += item.Price;
			}

			return totalPrice;
		}

		public void SubtractFromBalance(Decimal money)
		{
			this.Balance -= money;
		}

		public void Add1()
		{
			this.Balance += 1.00M;
		}

		public void Add2()
		{
			this.Balance += 2.00M;
		}

		public void Add5()
		{
			this.Balance += 5.00M;
		}

		public void Add10()
		{
			this.Balance += 10.00M;
		}

		/// <summary>
		/// Converts the difference after the sale and delivers back the change in quarters, dimes, and nickels
		/// </summary>
		public void MakeChange()
		{



			decimal changeBal = (this.Balance) * 100;
			Balance = 0.00M;

			Logger logger = new Logger(this);
			logger.LogMakeChange(changeBal, this.Balance);


			int quarters = 0;
			int dimes = 0;
			int nickels = 0;

			while (changeBal > 0)
			{
				if (changeBal >= 25)
				{
					quarters++;
					changeBal -= 25;
				}
				else if (changeBal >= 10)
				{
					dimes++;
					changeBal -= 10;
				}
				else if (changeBal >= 5)
				{
					nickels++;
					changeBal -= 5;
				}
			}

			Console.WriteLine($"Please accept your change: Quarters:{quarters}, Dimes:{dimes}, Nickels:{nickels}");
		}
	}
}
