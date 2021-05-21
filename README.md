# PizzaBox
  
## Project Description
The web application is designed for use by a pizza store employee to record incoming pizza orders. It allows the creation of new pizzas recipes, expandable due to the ability to add new ingredients, as well as store location inventory management. The employee can also examine customer information, searchable by name, and examine the sort-able order history, including orders to specific locations and by specific customers. The business logic prevents a customer from ordering at the same location within two hours of their last order.

## Technologies Used
- C#
- SQL Server/Azure SQL Databases
- ASP.NET Core Web API
- Entity Framework Core
- Asp.Net Core MVC
- .Net Core
- Git/GitHub

## Features

Ready features within project
* Users can sign in to view their order history or place new orders
* Users can build pizzas from scratch and fully customize the size, crust, and toppings or choose from a specialty pizza
* Users can view a menu with all the options to decide what they would like beforehand

Improvements for future iterations
* Add more pizza customizability options
* Implement functionality for the stores to view all pizza orders for their store as well analysis of past orders

## Installation
To install:
- In command line, use "git clone" this repository to create a repository on your machine.
- Download all the technologies listed above from their respective pages
- Set up an Azure SQL server following the instructions in Microsoft Azure Portal
- Within Visual Studio, select the open project in the home screen and select the files for this project.
- In PizzaBox.Data, configure the connection string to match that of your own SQL server.

## Usage
After installing, run PizzaBox.MVC and PizzaBox.API in two different instances of Visual Studio. This should open the PizzaBox website in your browser. You will see a few options in the navigation bar at the top. The first option is Home which will take you back to the index page. The second is a drop down that will display all the pizza options. The third is where you can actually create orders. When you click on it, you will be prompted to enter a couple fields including name and store. Following that, you are presented with a number of options to proceed, whether it be to check your order history or place a new order. 

## Contributors 
Kirby Chan

## Licenses
[MIT License](https://github.com/210329-UTA-SH-UiPath/P2_Team_SSJN/blob/main/LICENSE)

## Flow Chart

![Database Diagram](./DBDiagram.png)
