using eShopMobile.Application.Catalog.Products.DTO;
using eShopMobile.Application.Catalog.Products.DTO.Manage;
using eShopMobile.Application.CommonDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addQuantity);
        Task addViewCount(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
