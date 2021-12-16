using eShopMobile.Data.EF;
using eShopMobile.Data.Entity;
using eShopMobile.Ultilities.Exceptions;
using eShopMobile.ViewModels.System.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.Application.System.Roles
{
    public class RoleService : IRoleService
    {
        private readonly EShopDbContext _context;
        private readonly RoleManager<AppRole> _roleManager;
        public RoleService(RoleManager<AppRole> roleManager, EShopDbContext context)
        {
            _context = context;
            _roleManager = roleManager;
        }

        public Task<int> Create(RoleCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Delete(int roleId)
        {
            var role = await _context.Roles.FindAsync(roleId);
            if (role == null)
                throw new EShopException($"Cannot find a product: {roleId}");
            
            
            _context.Roles.Remove(role);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<RoleViewModel>> GetAll()
        {
            var roles = await _roleManager.Roles.Select(x => new RoleViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description
            }).ToListAsync();
            return roles;
        }

        public async Task<RoleViewModel> GetById(Guid roleId)
        {
            var role = await _context.Roles.FindAsync(roleId);
            var res = await _context.Roles
                .FirstOrDefaultAsync(x => x.Id == roleId);

            var categories = await(from r in _context.Roles
                                   where r.Id == roleId
                                   select r.Name).ToListAsync();

            var roleViewModel = new RoleViewModel()
            {
                Id = role.Id,
                Description = res != null ? res.Description : null,
                Name = res != null ? res.Name : null,
            };
            return roleViewModel;
        }

        public Task<int> Update(RoleUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
