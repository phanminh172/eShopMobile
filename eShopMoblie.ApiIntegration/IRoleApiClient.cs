using eShopMobile.ViewModels.Catalog.Products;
using eShopMobile.ViewModels.Common;
using eShopMobile.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopMobile.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleViewModel>>> GetAll();
        Task<PagedResult<RoleViewModel>> GetPagings(GetManageRolePagingRequest request);

        Task<bool> CreateRole(RoleCreateRequest request);
        Task<bool> UpdateRole(RoleUpdateRequest request);
        Task<bool> DeleteRole(Guid id);
        Task<RoleViewModel> GetById(Guid id, string languageId);
    }
}
