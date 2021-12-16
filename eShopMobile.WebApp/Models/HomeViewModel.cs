using eShopMobile.ViewModels.Catalog.Products;
using eShopMobile.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopMobile.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideViewModel> Slides { get; set; }

        public List<ProductViewModel> FeaturedProducts { get; set; }
        public List<ProductViewModel> LatestProducts { get; set; }
    }
}
