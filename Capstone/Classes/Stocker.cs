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
        /// <param name="inventory">The inventoy in the vending machine.</param>
        private void AddNewItemToVendingMachine(string line, Dictionary<string, VendingMachineItem> inventory)
        {
            string[] fields = line.Split('|');
            const int Col_Type = 3;
            const int Col_Name = 1;

            // Casting from a string to an enum
            // ItemType type = (ItemType)Enum.Parse(typeof(ItemType), fields[Col_Type]);            

            if (fields[Col_Type] == "Gum")
            {
                Gum gum = new Gum(fields[0], fields[Col_Name], decimal.Parse(fields[2]), fields[3]);
                inventory.Add(fields[0], gum);
            }
            else if (fields[Col_Type] == "Chip")
            {
                Chip chip = new Chip(fields[0], fields[Col_Name], decimal.Parse(fields[2]), fields[3]);
                inventory.Add(fields[0], chip);
            }
            else if (fields[Col_Type] == "Candy")
            {
                Candy candy = new Candy(fields[0], fields[Col_Name], decimal.Parse(fields[2]), fields[3]);
                inventory.Add(fields[0], candy);
            }
            else if (fields[Col_Type] == "Drink")
            {
                Drink drink = new Drink(fields[0], fields[Col_Name], decimal.Parse(fields[2]), fields[3]);
                inventory.Add(fields[0], drink);
            }


        }
    }


}
