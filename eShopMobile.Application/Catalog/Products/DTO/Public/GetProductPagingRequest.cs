﻿using eShopMobile.Application.CommonDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.Application.Catalog.Products.DTO.Public
{
    public class GetProductPagingRequest:PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
