using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
	public class VendingMachine
	{
		public Dictionary<string,VendingMachineItem> Stock { get; private set; }
		public decimal Balance { get; private set; }
		public List<VendingMachineItem> Cart { get; private set; }
		public decimal TotalPrice { get; set; }


		private Stocker stocker = new Stocker();
		public VendingMachine()
		{
			Stock = new Dictionary<string, VendingMachineItem>(stocker.Inventory);
			Cart = new List<VendingMachineItem>();
			Balance = 0;
			TotalPrice = 0;
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

	}
}
