using eShopMobile.ViewModels.Catalog.Products;
using eShopMobile.ViewModels.Common;
using System.Threading.Tasks;

namespace eShopMobile.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
    }
}
