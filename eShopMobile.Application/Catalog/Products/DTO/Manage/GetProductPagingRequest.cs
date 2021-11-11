﻿using eShopMobile.Application.CommonDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.Application.Catalog.Products.DTO.Manage
{
    public class GetProductPagingRequest:PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }

   
    }
}
