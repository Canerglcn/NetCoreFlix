using NetCoreFlixWEBUI.Business.Abstract;
using NetCoreFlixWEBUI.Entities;
using NetCoreFlixWEBUI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.Business.Concrete
{
    public class FavMovieService : IFavMovieService
    {
        public void AddToFavMovie(FavoriteMovies favMovies, Movie movie)
        {
            FavoriteMovie favmovie = favMovies.FavoriteMovieList.FirstOrDefault(f => f.Movie.MovieId == movie.MovieId);
            if(favmovie!=null)
            {
                //favmovie.GivenScore++;
                return;
            }
            favMovies.FavoriteMovieList.Add(new FavoriteMovie { Movie = movie, GivenScore = 1 });
        }

        public List<FavoriteMovie> List(FavoriteMovies favMovies)
        {
            return favMovies.FavoriteMovieList;
        }

        public void RemoveFromFavMovie(FavoriteMovies favMovies, int movieId)
        {
            favMovies.FavoriteMovieList.Remove(favMovies.FavoriteMovieList.FirstOrDefault(c=>c.Movie.MovieId==movieId));
        }
    }
}
