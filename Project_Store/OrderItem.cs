using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Project_Store
{
    class OrderItem
    //Amount = Quantidade
    {
        public int Amount { get; set; }
        public double PercentDiscount { get; set; }
        public Product product { get; set; }
        public Order order { get; set; }

        public OrderItem(int Amount, double PercentDiscount, Product product, Order order)
        {
            this.Amount = Amount;
            this.PercentDiscount = PercentDiscount;
            this.product = product;
            this.order = order;
        }

        public double SubTotal()
        {
            double Discount = product.Price * PercentDiscount / 100.0;
            return (product.Price * Discount) * Amount;
        }

        public override string ToString()
        {
            return "Product: "
                + product.Description
                + ", Price: "
                + product.Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Amount: "
                + Amount
                + ", Discount:"
                + PercentDiscount.ToString("F2", CultureInfo.InvariantCulture)
                + ", SubTotal: "
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
