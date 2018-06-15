using System;
using System.Collections.Generic;
using Capstone.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capstone.Tests
{
	[TestClass]
	public class VendingMachineTests
	{
		[TestMethod]
		public void Verify_FindTotalPrice()
		{
			VendingMachine vendingMachine = new VendingMachine();
			Drink drink = new Drink("A1", "Dr. Salt", 1.50M, "Drink");
			vendingMachine.Cart.Add(drink);


			Assert.AreEqual<decimal>(1.50M, vendingMachine.FindTotalPrice());


		}

		[TestMethod]
		public void Verify_SubtractFromBalance()
		{
			VendingMachine vendingMachine = new VendingMachine();
			Drink drink = new Drink("A1", "Dr. Salt", 1.50M, "Drink");
			vendingMachine.Cart.Add(drink);


			vendingMachine.Add2();
			vendingMachine.SubtractFromBalance(drink.Price);


			Assert.AreEqual<decimal>(.50M, vendingMachine.Balance);
		}

		[TestMethod]
		public void Verify_Add1()
		{
			VendingMachine vendingMachine = new VendingMachine();
			vendingMachine.Add1();

			Assert.AreEqual<decimal>(1.00M, vendingMachine.Balance);
		}

		[TestMethod]
		public void Verify_Add2()
		{
			VendingMachine vendingMachine = new VendingMachine();
			vendingMachine.Add2();

			Assert.AreEqual<decimal>(2.00M, vendingMachine.Balance);
		}

		[TestMethod]
		public void Verify_Add5()
		{
			VendingMachine vendingMachine = new VendingMachine();
			vendingMachine.Add5();

			Assert.AreEqual<decimal>(5.00M, vendingMachine.Balance);
		}

		[TestMethod]
		public void Verify_Add10()
		{
			VendingMachine vendingMachine = new VendingMachine();
			vendingMachine.Add10();

			Assert.AreEqual<decimal>(10.00M, vendingMachine.Balance);
		}


		[TestMethod]
		public void Verify_MakeChange()
		{
			VendingMachine vendingMachine = new VendingMachine();
			Drink drink = new Drink("A1", "Dr. Salt", 1.50M, "Drink");
			vendingMachine.Cart.Add(drink);


			vendingMachine.Add2();
			vendingMachine.SubtractFromBalance(drink.Price);
			vendingMachine.MakeChange();

			Assert.AreEqual<decimal>(0M, vendingMachine.Balance);
		}
	}
}
