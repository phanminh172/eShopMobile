using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.ViewModels.Catalog.Products
{
    public class ProductImageViewModel
    {
        public int Id { set; get; }
        public string FilePath { set; get; }
        public bool IsDefault { set; get; }
        public long FileSize { set; get; }
    }
}
