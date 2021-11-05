﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.Data.Entity
{
    public class AppRole:IdentityRole<Guid>
    {
        public string Description { set; get; }
    }
}
