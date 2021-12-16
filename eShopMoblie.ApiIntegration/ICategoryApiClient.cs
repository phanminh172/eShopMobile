using eShopMobile.ViewModels.Catalog.Categories;
using eShopMobile.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopMobile.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<PagedResult<CategoryViewModel>> GetPagings(GetManageCategoryPagingRequest request);
        Task<List<CategoryViewModel>> GetAll(string languageId);
        Task<CategoryViewModel> GetById(string languageId, int id);
        Task<bool> CreateCategory(CategoryCreateRequest request);
        Task<bool> UpdateCategory(CategoryUpdateRequest request);
        Task<bool> DeleteCategory(int id);
    }
}
