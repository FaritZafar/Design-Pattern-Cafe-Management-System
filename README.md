# Café Management System (CMS)

## Overview

The Café Management System (CMS) is a Windows Forms-based application designed to efficiently manage a café. The system aims to streamline the ordering process for customers while also helping administrators manage inventory and track orders. The CMS operates in kiosk mode, allowing customers to independently place their orders, which they can pay for via cash or card, eliminating the need for a cashier or receptionist.

## Features

- **Customer Interface**: Customers can place orders without the need for a cashier.
- **Order Tracking**: Keeps track of customer orders, including order status and payment.
- **Inventory Management**: Admin can manage the café's inventory.
- **Payment Processing**: Allows customers to pay using cash or card.
- **Kiosk Mode**: The application runs in kiosk mode, limiting user interaction to order placement and payment.

## Design Patterns Used

This project implements four design patterns to ensure clean, efficient, and scalable code:

1. **Singleton Pattern**: Ensures that a class has only one instance and provides a global point of access to it. Used for managing global resources like database connections and order management.
   
2. **Factory Pattern**: Creates objects without specifying the exact class of object that will be created. This pattern is useful for creating different types of items (e.g., drinks, food) dynamically based on user input.

3. **Strategy Pattern**: Allows algorithms to be selected at runtime. In this case, the strategy pattern is used for payment processing (Cash or Card), providing flexibility to switch payment methods based on customer choice.

4. **Facade Pattern**: Provides a simplified interface to a complex subsystem. Used to manage complex interactions between the inventory, orders, and payment systems by abstracting them behind a simple interface.

## Installation

### Prerequisites

- Windows OS
- .NET Framework (Version 4.5 or higher)
- Visual Studio (for building or modifying the project)
- SQL Server or any other relational database system for managing orders and inventory

### Steps to Run the Application

1. **Clone the Repository**

   ```bash
   git clone https://github.com/your-username/cafe-management-system.git
    Open the Project
        Open the project in Visual Studio.

    Configure Database
        Set up your database and modify the connection string in the app.config file to match your database configuration.

    Build and Run
        Build the solution by selecting Build > Build Solution from the menu.
        Press F5 or click Start to run the application in kiosk mode.

Usage
Customer View

    Upon starting the application, customers will be presented with a menu to select their items (e.g., food, drinks).
    Once the items are selected, they can choose to pay via cash or card.
    After payment, the system will display a confirmation and proceed with the order.

Administrator View

    Admin can monitor orders, manage inventory, and generate reports on sales and stock levels.
    The admin interface is password-protected and only accessible by authorized users.

Technologies Used

    C# - Primary programming language used.
    Windows Forms - For creating the user interface.
    SQL Server - For storing orders and inventory.
    .NET Framework - For application structure and managing the logic.

Contribution

Feel free to fork the repository, create a pull request, and contribute to the development of this project.
Guidelines for Contributing:

    Fork the repository and create your branch from main.
    Clone the repository locally and make changes.
    Commit your changes and push them to your branch.
    Open a Pull Request to the main branch with a clear description of what you have done.
