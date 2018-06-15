using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    /// <summary>
    /// Represents a drink item in the vending machine.
    /// </summary>
    class Drink : VendingMachineItem
    {
        public Drink(string slotLocation, string productName, decimal price, string itemType)
            : base(slotLocation, productName, price, itemType)
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string MakeConsumptionSound()
        {
            return "Glug Glug, Yum";
        }
    }
}
