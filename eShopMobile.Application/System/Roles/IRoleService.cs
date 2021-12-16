using eShopMobile.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.Application.System.Roles
{
    public  interface IRoleService
    {
        Task<List<RoleViewModel>> GetAll();
        Task<int> Create(RoleCreateRequest request);
        Task<int> Update(RoleUpdateRequest request);
        Task<int> Delete(int productId);
        Task<RoleViewModel> GetById(Guid roleId);
    }
}
