using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    /// <summary>
    /// Represents a gum item in the vending machine.
    /// </summary>
    class Gum : VendingMachineItem
    {
        public Gum(string slotLocation, string productName, decimal price, string itemType)
            : base(slotLocation, productName, price, itemType)
        { }

        /// <summary>
        /// The sound made when gum is consumed. 
        /// </summary>
        /// <returns>Chew Chew, Yum</returns>
        public override string MakeConsumptionSound()
        {
            return "Chew Chew, Yum";
        }
    }
}
