using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Project_Store
{
    class Order
    {
        public int Code { get; set; }
        public DateTime Date { get; set; }
        public static List<OrderItem> order = new List<OrderItem>();

        public Order(int Code, int Day, int Mouth, int Year)
        {
            this.Code = Code;
            Date = new DateTime(Year, Mouth, Day);
            order = new List<OrderItem>();
        }

        public double FullValor()
        {
            double sum = 0.0;
            for (int i = 0; i<order.Count; i++)
            {
                sum = sum + order[i].SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            return "Code of Order: "
                + Code + "\n"
                + "Request Date: "
                + Date.Day + "/" + Date.Month + "/" + Date.Year + "\n"
                + "$" + FullValor().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}