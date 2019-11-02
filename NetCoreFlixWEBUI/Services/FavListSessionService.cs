using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using NetCoreFlixWEBUI.Entities.Concrete;
using NetCoreFlixWEBUI.ExtensionsMethods;

namespace NetCoreFlixWEBUI.Services
{
    public class FavListSessionService : IFavListSessionService
    {
        private IHttpContextAccessor _httpContextAccessor;
        public FavListSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }


        public FavoriteMovies GetFavoriteMovies()
        {
            FavoriteMovies favToCheck= _httpContextAccessor.HttpContext.Session.GetObject<FavoriteMovies>("favMovies");
            if(favToCheck==null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("favMovies", new FavoriteMovies());
                favToCheck = _httpContextAccessor.HttpContext.Session.GetObject<FavoriteMovies>("favMovies");
            }
            return favToCheck;
        }

        public void SetFavoriteMovies(FavoriteMovies favMovies2)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("favMovies", favMovies2);
        }
    }
}
