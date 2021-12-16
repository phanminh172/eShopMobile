using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.ViewModels.Catalog.Categories
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }
        public bool? IsShowOnHome { get; set; }
    }
}
