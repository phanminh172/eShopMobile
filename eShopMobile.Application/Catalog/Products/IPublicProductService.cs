﻿using eShopMobile.ViewModels.Catalog.Products;
using eShopMobile.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopMobile.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
        //Task<List<ProductViewModel>> GetAll(string languageId);
    }
}
