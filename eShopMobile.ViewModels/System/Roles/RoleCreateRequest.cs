﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.ViewModels.System.Roles
{
    public class RoleCreateRequest
    {
        public string Name { get; set; }
        public string Description { set; get; }

    }
}
