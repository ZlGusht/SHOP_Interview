using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SHOP_Interview.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHOP_Interview.Common.ViewModels
{
    [BindProperties]
    public class ProductsViewModel : PageModel
    {
        public IList<Product> Products { get; set; }

        public ProductsViewModel()
        {
            Products = new List<Product>();

            Products.Add(new Product (1, "Chai", 18, 39, new DateTime(1996, 8, 20)));
        }
    }
}
