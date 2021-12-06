﻿using eShopMobile.ViewModels.System.Roles;
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
    }
}
