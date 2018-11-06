using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Project_Store
{
    class Product
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product(int Code, string Description, double Price)
        {
            this.Code = Code;
            this.Description = Description;
            this.Price = Price;
        }

        public override string ToString()
        {
            return "Code: "
                + Code
                + ", Product: "
                + Description
                + ", Price: $"
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
