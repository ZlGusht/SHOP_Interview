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

            Products.Add(new Product (1, "Chai", 18, 39, new DateTime(1996, 8, 20), "https://i2.wp.com/pipingpotcurry.com/wp-content/uploads/2019/05/How-to-make-Masala-Chai-Piping-Pot-Curry-500x375.jpg"));
            Products.Add(new Product(2, "Chang", 19, 17, new DateTime(1996, 7, 12), "https://www.saq.com/media/catalog/product/1/3/13593378-1_1578538524.png?quality=80&fit=bounds&height=&width="));
            Products.Add(new Product(4, "Chef Anton's Cajun Seasoning", 22, 53, new DateTime(1996, 9, 19), "https://www.dinneratthezoo.com/wp-content/uploads/2019/12/cajun-seasoning-4.jpg"));
            Products.Add(new Product(5, "Chef Anton's Gumbo Mix", 21.35, 0, new DateTime(1996, 7, 17), "https://d1e3z2jco40k3v.cloudfront.net/-/media/mccormick-us/products/zatarains/7/800/7142909542.png?vd=20200628T232728Z&hash=F431F6E40336830CDDFF79ED52CA3244"));
            Products.Add(new Product(6, "Grandma's Boysenberry Spread", 25, 120, new DateTime(1996, 9, 19), "https://tastykitchen.com/recipes/wp-content/uploads/sites/2/2014/07/20140706-15-410x410.jpg"));
            Products.Add(new Product(7, "Uncle Bob's Organic Dried Pears", 30, 0, new DateTime(1996, 7, 22), "https://nuts.com/images/rackcdn/ed910ae2d60f0d25bcb8-80550f96b5feb12604f4f720bfefb46d.ssl.cf1.rackcdn.com/7bf20a7479de37b6-OCBv5Tt_-zoom.jpg"));
            Products.Add(new Product(8, "Northwoods Cranberry Sauce", 40, 0, new DateTime(1996, 11, 1), "https://www.onceuponachef.com/images/2013/11/Cranberry-Sauce.jpg"));
            Products.Add(new Product(9, "Mishi Kobe Niku", 97, 19, new DateTime(1997, 1, 21), "https://www.debragga.com/pub/media/catalog/product/cache/4d1e5125532e93445b236bb399c47f42/d/b/dbsb1588_20190626500846_2.jpg"));
            Products.Add(new Product(3, "Aniseed Syrup", 10, 0, new DateTime(1996, 8, 26), "https://www.sbb-bg.com/image/cache/catalog/images/MONIN/Syrup/anise-hd_1-600x600.png"));
            Products.Add(new Product(10, "Ikura", 31, 31, new DateTime(1996, 8, 5), "https://img.japankuru.com/prg_img/img/img2020041514350428023300.jpg"));

        }
    }
}