using System;
using Capstone.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capstone.Tests
{
	[TestClass]
	public class VendingMachineItemTests
	{
		[TestMethod]
		public void Verify_MakeConsumptionSound()
		{
			Drink drink = new Drink("A1", "Compu-Tears", 1.50M, "Drink");
			Gum gum = new Gum("B1", "Com-Chew-ter", 0.90M, "Gum");
			Chip chip = new Chip("C1", "Computer Chips", 3.15M, "Chip");
			Candy candy = new Candy("D1", "Chocolate Computer Chips", 1.00M, "Candy");

			Assert.AreEqual<string>("Glug Glug, Yum", drink.MakeConsumptionSound());
			Assert.AreEqual<string>("Chew Chew, Yum", gum.MakeConsumptionSound());
			Assert.AreEqual<string>("Crunch Crunch, Yum", chip.MakeConsumptionSound());
			Assert.AreEqual<string>("Munch Munch, Yum", candy.MakeConsumptionSound());
		}
	}
}
