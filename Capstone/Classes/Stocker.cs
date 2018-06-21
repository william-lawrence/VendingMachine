using System;
using System.Collections.Generic;
using System.IO;

namespace Capstone.Classes
{
    /// <summary>
    /// Class that adds items to the vending machine. 
    /// </summary>
    public class Stocker
    {
        public Dictionary<string, VendingMachineItem> Inventory { get; private set; }

        public Stocker()
        {

            string path = Path.Combine(Environment.CurrentDirectory, "VendingMachine.csv");
            try
            {
                this.Inventory = new Dictionary<string, VendingMachineItem>();

                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        AddNewItemToVendingMachine(line, Inventory);

                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        /// <summary>
        /// Adds an item to the vending machine
        /// </summary>
        /// <param name="line">The line of text in the input file.</param>
        /// <param name="inventory">The inventory in the vending machine.</param>
        private void AddNewItemToVendingMachine(string line, Dictionary<string, VendingMachineItem> inventory)
        {
            string[] fields = line.Split('|');

            const int slotColumn = 0; // fields[0] is the slot
            const int nameColumn = 1; // fields[1] is the name
            const int priceColumn = 2; // fields[2] is the price
            const int typeColumn = 3; // fields[3] is the type

            if (fields[typeColumn] == "Gum")
            {
                Gum gum = new Gum(fields[slotColumn], fields[nameColumn], decimal.Parse(fields[priceColumn]), fields[typeColumn]);
                inventory.Add(fields[slotColumn], gum);
            }
            else if (fields[typeColumn] == "Chip")
            {
                Chip chip = new Chip(fields[slotColumn], fields[nameColumn], decimal.Parse(fields[priceColumn]), fields[typeColumn]);
                inventory.Add(fields[slotColumn], chip);
            }
            else if (fields[typeColumn] == "Candy")
            {
                Candy candy = new Candy(fields[slotColumn], fields[nameColumn], decimal.Parse(fields[priceColumn]), fields[typeColumn]);
                inventory.Add(fields[slotColumn], candy);
            }
            else if (fields[typeColumn] == "Drink")
            {
                Drink drink = new Drink(fields[slotColumn], fields[nameColumn], decimal.Parse(fields[priceColumn]), fields[typeColumn]);
                inventory.Add(fields[slotColumn], drink);
            }


        }
    }


}
