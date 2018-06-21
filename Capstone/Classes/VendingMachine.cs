using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        /// <summary>
        /// Represents all the items in the vending machine. The key is the slot location and value is a VendingMachineItem. 
        /// </summary>
		public Dictionary<string, VendingMachineItem> Stock { get; private set; }

        /// <summary>
        /// The amount of money available to spend to sped that has been input in the vending machine. 
        /// </summary>
		public decimal Balance { get; private set; }

        /// <summary>
        /// The list of all the items that the user has selected to purchase. 
        /// </summary>
		public List<VendingMachineItem> Cart { get; private set; }

        /// <summary>
        /// Represents the change to be dispensed.
        /// </summary>
        public Change change = new Change();

        // The stocker fills the vending machine.
        private Stocker stocker = new Stocker();

        public VendingMachine()
        {
            Stock = new Dictionary<string, VendingMachineItem>(stocker.Inventory);
            Cart = new List<VendingMachineItem>();
            Balance = 0;

        }

        /// <summary>
        /// Finds the total price of all the items in the cart.
        /// </summary>
        /// <returns>The total price of all the items in the cart.</returns>
		public decimal FindTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var item in this.Cart)
            {
                totalPrice += item.Price;
            }

            return totalPrice;
        }

        /// <summary>
        /// Removes money from the available balance
        /// </summary>
        /// <param name="money">The amount of money to remove from the balance.</param>
		public void SubtractFromBalance(Decimal money)
        {
            // Making sure that the machine wont accidentally add money to the balance.
            if (money > 0)
            {
                this.Balance -= money;
            }
        }

        /// <summary>
        /// Adds $1.00 to the balance.
        /// </summary>
		public void Add1()
        {
            this.Balance += 1.00M;
        }

        /// <summary>
        /// Adds $2.00 to the balance.
        /// </summary>
		public void Add2()
        {
            this.Balance += 2.00M;
        }

        /// <summary>
        /// Adds $5.00 to the balance.
        /// </summary>
		public void Add5()
        {
            this.Balance += 5.00M;
        }

        /// <summary>
        /// Adds $10.00 the balance.
        /// </summary>
		public void Add10()
        {
            this.Balance += 10.00M;
        }

        /// <summary>
        /// Converts the difference after the sale and delivers back the change in quarters, dimes, and nickels
        /// </summary>
        public void MakeChange()
        {
            decimal changeBal = (this.Balance) * 100;
            Balance = 0.00M;

            // The logger is used to record each of instance of money being feed to the machine
            Logger logger = new Logger(this);
            logger.LogMakeChange(changeBal, this.Balance);

            while (changeBal > 0)
            {
                if (changeBal >= 25)
                {
                    change.Quarters++;
                    changeBal -= 25;
                }
                else if (changeBal >= 10)
                {
                    change.Dimes++;
                    changeBal -= 10;
                }
                else if (changeBal >= 5)
                {
                    change.Nickels++;
                    changeBal -= 5;
                }
            }
        }
    }
}
