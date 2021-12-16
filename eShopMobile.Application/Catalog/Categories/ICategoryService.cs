using eShopMobile.ViewModels.Catalog.Categories;
using eShopMobile.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<int> Create(CategoryCreateRequest request);
        Task<int> Update(CategoryUpdateRequest request);
        Task<int> DeleteCategory(int productId);
        Task<List<CategoryViewModel>> GetAll(string languageId);
        Task<CategoryViewModel> GetById(string languageId,int id);
        Task<PagedResult<CategoryViewModel>> GetAllPaging(GetManageCategoryPagingRequest request);
    }
}
