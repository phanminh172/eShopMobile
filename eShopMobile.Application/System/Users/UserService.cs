using eShopMobile.Data.Entity;
using eShopMobile.ViewModels.System.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.Application.System.Users
{
    public class UserService:IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<bool> Authenticate(LoginRequest request)
        {
            var user = _userManager.FindByNameAsync(request.UserName);
            var result=_signInManager.PasswordSignInAsync()
        }

        Task<bool> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
