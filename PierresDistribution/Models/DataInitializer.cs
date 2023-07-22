// // DEVELOPMENT DATA ONLY, DELETE IN PRODUCTION

// using PierresDistribution.Models;
// using System;
// using System.Collections.Generic;

// namespace PierresDistribution
// {
//     public static class DataInitializer
//     {
//         public static void InitializeData()
//         {
//             // Test products.
//             Bread bread1 = new Bread("Pumpernickel", 4.5m);
//             Bread bread2 = new Bread("Whole Wheat", 5.0m);
//             Bread bread3 = new Bread("White", 3.5m);

//             Pastry pastry1 = new Pastry("Croissant", 2.5m);
//             Pastry pastry2 = new Pastry("Cannoli", 3.0m);
//             Pastry pastry3 = new Pastry("Eclaire", 4.0m);

//             // Test vendors.
//             Vendor vendor1 = new("Billy's Bakery");
//             Vendor vendor2 = new("Crazy Croissants");
//             Vendor vendor3 = new("Bread-O-Rama");

//             // Test OrderItems.
//             OrderItem orderItem1 = new OrderItem(bread1, 10);
//             OrderItem orderItem2 = new OrderItem(pastry2, 15);
//             OrderItem orderItem3 = new OrderItem(bread3, 20);
//             OrderItem orderItem4 = new OrderItem(pastry1, 25);
//             OrderItem orderItem5 = new OrderItem(bread2, 30);
//             OrderItem orderItem6 = new OrderItem(pastry3, 35);

//             // Test Orders.
//             Order order1 = new Order(070523, orderItem1, orderItem2);
//             Order order2 = new Order(071023, orderItem3, orderItem4);
//             Order order3 = new Order(071523, orderItem5, orderItem6);

//             // Add Orders to Vendors.
//             vendor1.AddOrder(order1);
//             vendor2.AddOrder(order2);
//             vendor3.AddOrder(order3);
//         }
//     }
// }
