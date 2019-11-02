using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using NetCoreFlixWEBUI.Entities.Concrete;
using NetCoreFlixWEBUI.Models;
using NetCoreFlixWEBUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.ViewComponents
{
    public class FavListSummaryViewComponent:ViewComponent
    {
        private IFavListSessionService _favListSessionService;

        public FavListSummaryViewComponent(IFavListSessionService favListSessionService)
        {
            _favListSessionService = favListSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new FavListSummaryViewModel
            {
                FavoriteMovies =_favListSessionService.GetFavoriteMovies()
            };
            return View(model);
        }

    }
}
