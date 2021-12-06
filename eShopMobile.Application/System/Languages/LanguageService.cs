using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using eShopMobile.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using eShopMobile.ViewModels.System.Languages;
using eShopMobile.Data.EF;

namespace eShopMobile.Application.System.Languages
{
    public class LanguageService : ILanguageService
    {
        
        private readonly IConfiguration _config;
        private readonly EShopDbContext _context;

        public LanguageService( EShopDbContext context,IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public async Task<ApiResult<List<LanguageViewModel>>> GetAll()
        {
            var languages = await _context.Languages.Select(x => new LanguageViewModel()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();
            return new ApiSuccessResult<List<LanguageViewModel>>(languages) ;
        }
    }
}
