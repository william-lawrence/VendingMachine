using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    /// <summary>
    /// Represents a chip item in the vending machine.
    /// </summary>
    public class Chip : VendingMachineItem
    {
        public Chip(string slotLocation, string productName, decimal price, string itemType)
            : base(slotLocation, productName, price, itemType)
        { }

        /// <summary>
        /// The sound made when chip is consumed.
        /// </summary>
        /// <returns>Crunch Crunch, Yum</returns>
        public override string MakeConsumptionSound()
        {
            return "Crunch Crunch, Yum";
        }
    }
}
