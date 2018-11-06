using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Project_Store
{
    class Screen
    {
        public static void ShowScreen()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("-Nameless Virtual Store-");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Product Register");
            Console.WriteLine("2 - Order Register");
            Console.WriteLine("3 - Show Saved Products");
            Console.WriteLine("4 - Show Saved Orders");
            Console.WriteLine("5 - Exit");
            Console.Write("Your Choise: ");

        }

        public static void ShowSavedProducts()
        {
            Console.WriteLine("Saved Products: ");
            for (int i = 1; i < Program.products.Count; i++)
            {
                Console.WriteLine(Program.products[i]);
            }
        }

        public static void ShowSavedOrders()
        {
            Console.WriteLine("Saved Orders: ");
            Console.Write("Insert the Code of Product: ");
            int CodeProduct = int.Parse(Console.ReadLine());
            int pos = Program.orders.FindIndex(x => x.Code == CodeProduct);
            if (pos == -1)
            {
                Console.WriteLine("404 ERROR: Code " + CodeProduct + " Not Found.");
            }
            Console.WriteLine(Program.orders[pos]);

        }
        public static void ProductRegister()
        {
            Console.Write("Insert the amount of products that will be registered: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Insert the dates from " + "º product: ");
                Console.Write("Product: ");
                string Description = Console.ReadLine();
                Console.WriteLine("Code: ");
                int Code = int.Parse(Console.ReadLine());
                Console.Write("Price: $");
                double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product P = new Product(Code, Description, Price);
                Program.products.Add(P);
            }
        }
        public static void OrderRegister()
        {
            Console.Write("Insert the amount of orders that will be registered: ");
            Console.Write("Order's Code: ");
            int Code = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the date of Order: ");
            Console.Write("Day: ");
            int Day = int.Parse(Console.ReadLine());
            Console.Write("Mounth: ");
            int Mounth = int.Parse(Console.ReadLine());
            Console.Write("Year: ");
            int Year = int.Parse(Console.ReadLine());
            Order O = new Order(Code, Day, Mounth, Year);
            Console.WriteLine("Insert the amount of Products that will be Ordered: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i<=N; i++)
            {
                Console.WriteLine("Insert the data of " + i + "º product: ");
                Console.Write("Code: ");
                int CodeProduct = int.Parse(Console.ReadLine());
                int pos = Program.products.FindIndex(x => x.Code == CodeProduct);
                if (pos == -1)
                {
                    Console.WriteLine("404 ERROR: Code " + CodeProduct + " not found.");
                }
                Console.Write("Insert the total units requested: ");
                int Amount = int.Parse(Console.ReadLine());
                Console.Write("Insert the percent of discount: ");
                double PercentDiscount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                OrderItem OI = new OrderItem(Amount, PercentDiscount, Program.products[pos], O);
                Order.order.Add(OI);
                Console.WriteLine("Order Regitered!");
            }
            Program.orders.Add(O);
        } 
    }
}