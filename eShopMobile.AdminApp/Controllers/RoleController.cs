using eShopMobile.ApiIntegration;
using eShopMobile.Ultilities.Constants;
using eShopMobile.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopMobile.AdminApp.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleApiClient _roleApiClient;
        private readonly IConfiguration _configuration;

        public RoleController(IRoleApiClient roleApiClient,
            IConfiguration configuration )
        {
            _configuration = configuration;
            _roleApiClient = roleApiClient;
        }
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 5)
        {
            //var languageId = HttpContext.Session.GetString(SystemConstants.AppSettings.DefaultLanguageId);
            var request = new GetManageRolePagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _roleApiClient.GetPagings(request);
            ViewBag.Keyword = keyword;

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
