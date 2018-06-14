using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public abstract class VendingMachingItem
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


        public VendingMachingItem(string slotLocation, string productName, decimal price, ItemType itemType )
        {
            this.SlotLocation = slotLocation;
            this.ProductName = productName;
            this.Price = price;
            this.ItemType = itemType;
            this.Quantity = 5;
        }


        /// <summary>
        /// The sound made when the product is consumed.
        /// </summary>
        /// <returns>The sound made by a particular item type</returns>
        public abstract string MakeConsumptionSound();

    }
}
