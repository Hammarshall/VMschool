# School assignment: Vending Machine

The task was to create a program that simulates a vending machine for purchasing various products. The program includes a menu where the user can choose between different products snacks, certified info and drinks. There is also a function for handling the payments and to return the money when the user exits the program in choosen currency’s. The purpose of this task is to test my programming knowledge and to work after a specification.

My abstract class is VendingItem, Beverage, ClassifiedInfo, Snack contains attributes for name, cost, and description. When a product is selected, the user is able to see the product's description and price. Before the purchase is completed the user also gets to input how many they want to purchase. The user is be able to accept the purchase or go back to the menu.

When the user accepts and purchase a product, the product will be purchased and used and a snippet if text will appear thats tailormade for every item. When purchasing a product, a check will be made to ensure the user has inserted enough money into the vending machine. If not, the purchase will be stopped and the user is brought back to the start menu.

When the purchase is completed the user is be brought back to the menu. To exit the program the user simply selects the menu option to end the program. When the user chooses to end the program, the remaining money in the vending machine will be returned to the user. The amount of money returned and the denomination will be printed out.

A option in the menu is allowing the user to freely input money into the vending machine. The user is able to see how much money is in the machine and how much they have left in their wallet.

## Abstract class: VendingItem

- Product name
- Price
- Product Description
- Function to display the product description, price and currency
- Function to display the products name

## Each product type is a abstract class that inherits from VendingItem and the interface IVendingItem

- Beverage
- ClassifiedInfo
- Snack

## ProductCategory:

- a bool if its empty (if you have used the item or not)
- Function Use() called when the user purchase the item and the tailiormade text appears
- Function Buy() called after the purchase is controlled and vaid, dislays the name of the item what the user bought and price.
- Function Price() returns the product price

## Interface: IVendingItem:

- Function Use()
- Function Description()
- Function Buy()
- Function Price()
- Function ShowProductName()

## Class: Money

- Tracks money fed into the system
- Has a method that calculates change/coins based on values it's given

## Menu

- StartMenu, starts the program
- VendingMachine, Displays the main menu where the user can choose to: See all Beverages, See all Snacks, See all Classified info, Insert Money, and Exit program.

  Depending on what the user picks the user is taken to for example Bevrage Menu (Called BevMenu()) and there the user can see all Bevrages that the Vending Machine offers and choose what product they whant to select to see description and price.

  - The other menus for snacks and ClassifiedInfo is structured the same, but with diffrent prices, products and descriptions
