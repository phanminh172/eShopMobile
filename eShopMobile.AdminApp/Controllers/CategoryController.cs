﻿using eShopMobile.ApiIntegration;
using eShopMobile.Ultilities.Constants;
using eShopMobile.ViewModels.Catalog.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopMobile.AdminApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ICategoryApiClient _categoryApiClient;

        public CategoryController(IConfiguration configuration,
            ICategoryApiClient categoryApiClient)
        {
            _configuration = configuration;
            _categoryApiClient = categoryApiClient;
        }
        public async Task<IActionResult> Index(string keyword, int? categoryId, int pageIndex = 1, int pageSize = 2)
        {
            var languageId = HttpContext.Session.GetString(SystemConstants.AppSettings.DefaultLanguageId);
            var request = new GetManageCategoryPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
                LanguageId = languageId
            };
            var data = await _categoryApiClient.GetPagings(request);
            //var data = await _categoryApiClient.GetAll(languageId);
            ViewBag.Keyword = keyword;

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] CategoryCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _categoryApiClient.CreateCategory(request);
            if (result)
            {
                TempData["result"] = "Thêm mới sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm sản phẩm thất bại");
            return View(request);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var languageId = HttpContext.Session.GetString(SystemConstants.AppSettings.DefaultLanguageId);

            var category = await _categoryApiClient.GetById(languageId,id);
            var editVm = new CategoryUpdateRequest()
            {
                Id = category.Id,
                Name = category.Name,
                SeoAlias = category.SeoAlias,
                SeoDescription = category.SeoDescription,
                SeoTitle = category.SeoTitle,
                ParentId=category.ParentId,
                SortOrder = category.SortOrder
            };
            return View(editVm);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Edit([FromForm] CategoryUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _categoryApiClient.UpdateCategory(request);
            if (result)
            {
                TempData["result"] = "Cập nhật sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Cập nhật sản phẩm thất bại");
            return View(request);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(new CategoryDeleteRequest()
            {
                Id = id
            });
        }
        [HttpPost]
        public async Task<IActionResult> Delete(CategoryDeleteRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _categoryApiClient.DeleteCategory(request.Id);
            if (result)
            {
                TempData["result"] = "Xóa sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Xóa không thành công");
            return View(request);
        }
        [HttpGet]
        public async Task<ActionResult> Detail(int id)
        {
            var languageId = HttpContext.Session.GetString(SystemConstants.AppSettings.DefaultLanguageId);
            var result = await _categoryApiClient.GetById(languageId,id);
            return View(result);
        }
    }
}
