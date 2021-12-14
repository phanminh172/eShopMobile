using eShopMobile.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMobile.Application.Utilities
{
    public interface ISlideService
    {
        Task<List<SlideViewModel>> GetAll();
    }
}
