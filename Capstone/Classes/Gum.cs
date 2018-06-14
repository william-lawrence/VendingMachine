using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    class Gum : VendingMachineItem
    {
        public Gum(string slotLocation, string productName, decimal price, string itemType)
            : base(slotLocation, productName, price, itemType)
        { }

        public override string MakeConsumptionSound()
        {
            return "Chew Chew, Yum";
        }
    }
}
