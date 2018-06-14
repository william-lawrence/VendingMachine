using System;
using System.Collections.Generic;
using System.IO;

namespace Capstone.Classes
{
    public class Stocker
    {
        public Dictionary<string, VendingMachineItem> inventory = new Dictionary<string, VendingMachineItem>();

        public Stocker()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "VendingMaching.csv");
            try
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        AddNewItemToVendingMachine(line, inventory);

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
        /// <param name="line"></param>
        /// <param name="inventory"></param>
        private void AddNewItemToVendingMachine(string line, Dictionary<string, VendingMachineItem> inventory)
        {
            string[] fields = line.Split('|');


            if (fields[3] == "Gum")
            {
                Gum gum = new Gum(fields[0], fields[1], decimal.Parse(fields[2]), fields[3]);
                inventory.Add(fields[0], gum);
            }
            else if (fields[3] == "Chip")
            {
                Chip chip = new Chip(fields[0], fields[1], decimal.Parse(fields[2]), fields[3]);
                inventory.Add(fields[0], chip);
            }
            else if (fields[3] == "Candy")
            {
                Candy candy = new Candy(fields[0], fields[1], decimal.Parse(fields[2]), fields[3]);
                inventory.Add(fields[0], candy);
            }
            else if (fields[3] == "Drink")
            {
                Drink drink = new Drink(fields[0], fields[1], decimal.Parse(fields[2]), fields[3]);
                inventory.Add(fields[0], drink);
            }


        }
    }


}
