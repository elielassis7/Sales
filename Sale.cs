using System;
using System.Collections.Generic;
using System.Globalization;


namespace Sales
{
    class Sale
    {
        public String Product { get; set; }
        public double Price { get; set; }
        public int Quantaty { get; set; }

        public Sale(string product, double price, int quantaty)
        {
            Product = product;
            Price = price;
            Quantaty = quantaty;
        }

        public double TotalPrice()
        {
            return Price * Quantaty;
        }

        public override string ToString()
        {
            return Product + ": " + TotalPrice().ToString("C2");
        }
    }
}
