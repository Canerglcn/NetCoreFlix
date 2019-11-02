using NetCoreFlixWEBUI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.Services
{
    public interface IFavListSessionService
    {
        FavoriteMovies GetFavoriteMovies();
        void SetFavoriteMovies(FavoriteMovies favMovies);
    }
}
