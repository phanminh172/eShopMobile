using eShopMobile.ViewModels.Common;
using eShopMobile.ViewModels.System.Languages;
using eShopMobile.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageViewModel>>> GetAll();

       
    }
}
