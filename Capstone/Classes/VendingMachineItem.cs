using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public abstract class VendingMachineItem
    {
        /// <summary>
        /// Slot where the item is stored
        /// </summary>
        public string SlotLocation { get; private set; }

        /// <summary>
        /// Name of the product
        /// </summary>
        public string ProductName { get; private set; }

        /// <summary>
        /// Price of the product.
        /// </summary>
        public decimal Price { get; private set; }

        /// <summary>
        /// Type of the product.
        /// </summary>
        public ItemType ItemType { get; private set; }

        /// <summary>
        /// Quantity of the product.
        /// </summary>
        public int Quantity { get; private set; }


        public VendingMachineItem(string slotLocation, string productName, decimal price, string itemType)
        {
            this.SlotLocation = slotLocation;
            this.ProductName = productName;
            this.Price = price;
            
            this.Quantity = 5;

            if (itemType.ToLower() == "gum")
            {
                this.ItemType = ItemType.Gum;
            }
            else if (itemType.ToLower() == "chips")
            {
                this.ItemType = ItemType.Chip;
            }
            else if (itemType.ToLower() == "drink")
            {
                this.ItemType = ItemType.Chip;
            }
            else if (itemType.ToLower() == "candy")
            {
                this.ItemType = ItemType.Candy;
            }
        }


        /// <summary>
        /// The sound made when the product is consumed.
        /// </summary>
        /// <returns>The sound made by a particular item type</returns>
        public abstract string MakeConsumptionSound();

    }
}
