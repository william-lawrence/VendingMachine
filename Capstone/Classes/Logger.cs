using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone.Classes
{
    /// <summary>
    /// Log all transactions and records them to a text file.
    /// </summary>
	public class Logger
    {
        public VendingMachine Vm { get; set; }
        public Logger(VendingMachine vm)
        {
            this.Vm = vm;
        }

        /// <summary>
        /// Records the amount of money fed into the machine and logs it in Log.txt.
        /// </summary>
        /// <param name="money">Amount of money fed into the machine.</param>
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
            catch (IOException ex)
            {
                Console.WriteLine("Error Writing File " + ex.Message);
            }
        }

        /// <summary>
        /// Records an item purchased from the machine and logs it in Log.txt.
        /// </summary>
        /// <param name="item"></param>
		public void LogVendItem(VendingMachineItem item)
        {
            string outputPath = Path.Combine(Environment.CurrentDirectory, "Log.txt");
            try
            {
                using (StreamWriter sw = new StreamWriter(outputPath, true))
                {
                    sw.WriteLine($"{ DateTime.Now} {item.ProductName.PadRight(20)} {item.SlotLocation.PadRight(2)} {(Vm.Balance).ToString("C2").PadLeft(10)}     {(Vm.Balance - item.Price).ToString("C2").PadLeft(10)}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error Writing File" + ex.Message);
            }
        }

        /// <summary>
        /// Records the amount of change given to the user and logs it in Log.txt.
        /// </summary>
        /// <param name="changeGiven">Amount of change given to the user.</param>
        /// <param name="finalBalance">Balance after all the change has been given back.</param>
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
            catch (IOException ex)
            {
                Console.WriteLine("Error Writing File" + ex.Message);
            }
        }


    }
}