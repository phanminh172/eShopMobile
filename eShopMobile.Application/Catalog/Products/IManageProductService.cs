using eShopMobile.ViewModels.Catalog.ProductImages;
using eShopMobile.ViewModels.Catalog.Products;
using eShopMobile.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
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
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
        Task<ProductViewModel> GetById(int productId, string languageId);
        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<List<ProductImageViewModel>> GetListImages(int productId);
    }
}
