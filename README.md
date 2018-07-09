# Vending Machine

## Introduction
The vending machine program is mini capstone project that I created at Tech Elevator, the coding bootcamp that I attended. The program 
stocks the vending machine via text file. In this case it is the VendingMachine.csv. 

## Requirements
- The vending machine needs to dispense 4 types of food: candy, chips, drinks, and gum.
- A main menu should display when the menu is running and display the following items.
    1. Display Vending Machine Items
    2. Purchase
- The vending machine should stock its inventory from a text file.
- the vending machine is restocked every time the application is run. 
- When the customer selects (1) Display Vending Machine Items they are presented a list of all items in the vending machine with its quantity remaining.
    1. Each vending machine product has a slot identifier and a purchase price.
    2. Each slot in the vending machine has enough room for 5 of that product.
    3. Every product is initially stocked to the maximum amount.
    4. A product which has run out should indicate it is SOLD OUT
- When the customer selects (2) Purchase they are guided through the purchasing process menu:
    1. Feed Money
    2. Select Product
    3. Finish Transaction
    - This menu should also display the money that has already been input. 
- The purchase process flow is as follows:
    1. Selecting (1) Feed Money A customer can repeatedly feed money into the machine in whole dollar amounts (e.g. $1, $2, $5, $10).
        - The current money provided indicates how much money the customer has fed into the machine
    2. Selecting (2) Select Product allows the customer to select a product to purchase.
        - If the product code does not exist, the customer is informed and returned to the Purchase menu.
        - If a product is sold out, the customer is informed and returned to the Purchase menu.
        - If a valid product is selected it is dispensed to the customer.
        - After the product is dispensed, the machine should update its balance accordingly and return the customer to the Purchase menu
    3. Selecting (3) Finish Transaction allows the customer to complete the transaction and receive any remaining change back.
        - The customer’s money is returned using nickels, dimes, and quarters (using the smallest amount of coins possible).
        - The machine’s current balance should be updated to $0 remaining.
        - i. The item(s) will be “consumed” and a message printed depending on the item type:
            1. All chip items will return “Crunch Crunch, Yum!”
            2. All candy items will return “Munch Munch, Yum!”
            3. All drink items will return “Glug Glug, Yum!”
            4. All gum items will return “Chew Chew, Yum!”
-   All purchases must be audited to prevent theft from the vending machine
    - Each purchase should generate a line in a file called Log.txt
    - b. The audit entry should be in the format:  

01/01/2016 12:00:00 PM FEED MONEY: $5.00 $5.00  
01/01/2016 12:00:15 PM FEED MONEY: $5.00 $10.00  
01/01/2016 12:00:20 PM Crunchie B4 $10.00 $8.50  
01/01/2016 12:01:25 PM Cowtales B2 $8.50 $7.50  
01/01/2016 12:01:35 PM GIVE CHANGE: $7.50 $0.00  


- There should be unit tests in place in order to test the program.





