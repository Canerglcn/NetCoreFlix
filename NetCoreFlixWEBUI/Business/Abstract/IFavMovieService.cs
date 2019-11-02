using NetCoreFlixWEBUI.Entities;
using NetCoreFlixWEBUI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.Business.Abstract
{
    public interface IFavMovieService
    {
        void AddToFavMovie(FavoriteMovies favMovies, Movie movie);
        void RemoveFromFavMovie(FavoriteMovies favMovies, int movieId);
        List<FavoriteMovie> List(FavoriteMovies favMovies);
    }
}
