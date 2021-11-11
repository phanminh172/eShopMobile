using eShopMobile.Application.Catalog.Products.DTO;
using eShopMobile.Application.Catalog.Products.DTO.Public;
using eShopMobile.Application.CommonDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
