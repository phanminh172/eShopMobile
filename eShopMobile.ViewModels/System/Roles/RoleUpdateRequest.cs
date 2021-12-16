using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.ViewModels.System.Roles
{
    public class RoleUpdateRequest
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        
    }
}
