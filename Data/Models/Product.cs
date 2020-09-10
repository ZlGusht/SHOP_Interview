using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP_Interview.Data.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public double ProductPrice { get; set; }

        public int UnitsInStock { get; set; }

        public DateTime DeliveryOn { get; set; }

        public Product(int productId, string productName, double productPrice, int unitsInStock, DateTime deliveryOn)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            UnitsInStock = unitsInStock;
            DeliveryOn = deliveryOn;
        }
    }
}
