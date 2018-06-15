﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    class Drink : VendingMachineItem
    {
        public Drink(string slotLocation, string productName, decimal price, string itemType)
            : base(slotLocation, productName, price, itemType)
        { }

        public override string MakeConsumptionSound()
        {
            return "Glug Glug, Yum";
        }
    }
}
