using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone.Classes
{
	public class Logger
	{
		public VendingMachine Vm { get; set; }
		public Logger(VendingMachine vm)
		{
			this.Vm = vm;
		}


		public void LogFeedMoney(decimal money)
		{
			string outputPath = Path.Combine(Environment.CurrentDirectory, "Log.txt");
			try
			{
				using (StreamWriter sw = new StreamWriter(outputPath, true))
				{
					sw.WriteLine($"{DateTime.Now} FEED MONEY {(money).ToString("C2").PadLeft(23)}     {(Vm.Balance).ToString("C2").PadLeft(10)}");
				}

			}
			catch(IOException ex)
			{
				Console.WriteLine("Error Writing File " + ex.Message);
			}
		}

		public void LogVendItem(VendingMachineItem item)
		{
			string outputPath = Path.Combine(Environment.CurrentDirectory, "Log.txt");
			try
			{
				using (StreamWriter sw = new StreamWriter(outputPath, true))
				{
					sw.WriteLine($"{ DateTime.Now} {item.ProductName.PadRight(20)} {item.SlotLocation.PadRight(2)} {(Vm.Balance).ToString("C2").PadLeft(10)}     {(Vm.Balance-item.Price).ToString("C2").PadLeft(10)}");
				}
			}
			catch(IOException ex)
			{
				Console.WriteLine("Error Writing File" + ex.Message);
			}
		}

		public void LogMakeChange(decimal changeGiven, decimal finalBalance)
		{
			string outputPath = Path.Combine(Environment.CurrentDirectory, "Log.txt");
			try
			{
				using (StreamWriter sw = new StreamWriter(outputPath, true))
				{
					sw.WriteLine($"{DateTime.Now} GIVE CHANGE: {(changeGiven / 100).ToString("C2").PadLeft(21).PadRight(10)}     {(finalBalance).ToString("C2").PadLeft(10)}");
				}

			}
			catch(IOException ex)
			{
				Console.WriteLine("Error Writing File" + ex.Message);
			}
		}


	}
}