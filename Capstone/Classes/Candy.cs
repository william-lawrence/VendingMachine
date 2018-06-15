using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    /// <summary>
    /// Represents a candy item in the vending machine.
    /// </summary>
    public class Candy : VendingMachineItem
    {
        public Candy(string slotLocation, string productName, decimal price, string itemType)
            : base(slotLocation, productName, price, itemType)
        { }

        /// <summary>
        /// The sound made when candy is consumed.
        /// </summary>
        /// <returns>Munch Munch, Yum</returns>
        public override string MakeConsumptionSound()
        {
            return "Munch Munch, Yum";
        }
    }
}
