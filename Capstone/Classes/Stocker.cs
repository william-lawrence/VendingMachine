using System;
using System.Collections.Generic;
using System.IO;

namespace Capstone.Classes
{
    public class Stocker
    {
        public Dictionary<string, List<VendingMachineItem>> inventory = new Dictionary<string, List<VendingMachineItem>>();

		public Stocker(Dictionary<string, List<VendingMachineItem>>)
		{
			string path = Path.Combine(Environment.CurrentDirectory, "VendingMaching.csv");
			try
			{

                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

		private static AddVendingMachineItemToDictionary(Dictionary<string, List<VendingMachineItem>>)
		{
			if (inventory.ContainsKey(vm.Slot))
			{
				inventory[vm.Slot].Add(vm);
			}
			else
			{
				inventory[vm.Slot] = new List<VendingMachineItem>();
				inventory[vm.slotLocation].Add(vm);
			}

        private static AddVendingMachineItemToDictionary(Dictionary<string, List<VendingMachineItem>>)
        {
            if (inventory.ContainsKey(vm.Slot))
            {
                inventory[vm.Slot].Add(vm);
            }
            else
            {
                inventory[vm.Slot] = new List<VendingMachineItem>();
                inventory[vm.Slot].Add(vm);
            }

		private  static VendingMachineItem GetVendingMachineItemFromLine(string line)
		{
			string[] fields = line.Split('|');

			if (fields[3] == "Gum")
			{
						string name = fields[1].t;
						 Gum name = new Gum(fields[0], fields[1], decimal.Parse(fields[2]), fields[3]);

			}
			VendingMachineItem vendingMachineItem = new Gum();
		}




    }
}
