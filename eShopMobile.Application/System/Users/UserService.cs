
using eShopMobile.Data.Entity;
using eShopMobile.ViewModels.System.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShopMobile.Utilities.Exceptions;
using System.Security.Claims;

namespace eShopMobile.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        //public async Task<bool> Authenticate(LoginRequest request)
        //{
        //    var user =await _userManager.FindByNameAsync(request.UserName);
        //    if (user == null) throw new EShopException("Cannot find valid user");
        //    var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
        //    if (!result.Succeeded)
        //    {
        //        return false;
        //    }
        //    var claims = new[]
        //    {
        //        new Claim(ClaimTypes.Email,user.Email),
        //        new Claim(ClaimTypes.GivenName,user.FirstName),
        //    }
        //}

        Task<bool> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
