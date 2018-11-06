using System;
using System.Collections.Generic;

namespace Project_Store
{
    class Program
    {
        public static List<Product> products = new List<Product>();
        public static List<Order> orders = new List<Order>();

        static void Main(string[] args)
        {
            int option = 0;

            products.Add(new Product(1001, "Chair", 50.00));
            products.Add(new Product(1002, "Table", 100.00));
            products.Add(new Product(1003, "Lone Coach", 400.00));
            products.Add(new Product(1004, "Twin Coach", 450.00));
            products.Add(new Product(1005, "Triple Coach", 470.00));
            products.Add(new Product(1007, "Freezer", 980.90));

            while (option != 5)
            {
                Console.Clear();
                Screen.ShowScreen();

                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Internal Error " + e.Message);
                    option = 0;
                }

                if (option == 1)
                {
                    Screen.ProductRegister();
                    Console.WriteLine("Successfully registered!");
                    Console.WriteLine("Press 'ENTER' to continue.");

                    try
                    {
                        option = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Internal Error " + e.Message);
                        option = 0;
                    }
                }

                else if (option == 2)
                {
                    Screen.OrderRegister();
                    Console.WriteLine("Successfully registered!");
                    Console.WriteLine("Press 'ENTER' to continue.");

                    try
                    {
                        option = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Internal Error " + e.Message);
                        option = 0;
                    }
                }

                else if (option == 3)
                {
                    Screen.ShowSavedProducts();
                }

                else if (option == 4)
                {
                    Screen.ShowSavedOrders();
                }

                else if (option == 5)
                {
                    Console.WriteLine("Have a good day.");
                }

                else
                {
                    Console.WriteLine("What a heck you are trying to do? I got some errors here!");
                    Console.WriteLine("Press 'ENTER' to forgot your stupid idea and continue.");
                }

                Console.ReadLine();
            }
        }
    }
}