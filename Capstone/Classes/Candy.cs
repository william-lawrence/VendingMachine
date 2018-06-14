using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    class Candy : VendingMachineItem
    {
        public Candy(string slotLocation, string productName, decimal price, ItemType itemType)
            : base(slotLocation, productName, price, itemType)
        { }

        public override string MakeConsumptionSound()
        {
            return "Munch Munch, Yum";
        }
    }
}
