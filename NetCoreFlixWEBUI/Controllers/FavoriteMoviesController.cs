using Microsoft.AspNetCore.Mvc;
using NetCoreFlixWEBUI.Business.Abstract;
using NetCoreFlixWEBUI.Entities.Concrete;
using NetCoreFlixWEBUI.Models;
using NetCoreFlixWEBUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.Controllers
{
    public class FavoriteMoviesController:Controller
    {
        private IFavListSessionService _favListSessionService;
        private IFavMovieService _favMovieService;
        private IMovieService _movieService;

        public FavoriteMoviesController(
            IFavListSessionService favListSessionService,
            IFavMovieService favMovieService,
            IMovieService movieService)
        {
            _favListSessionService = favListSessionService;
            _favMovieService = favMovieService;
            _movieService = movieService;
        }
        
        public ActionResult AddToFav(int movieId)
        {
            var movieToBeAdded = _movieService.GetById(movieId);

            var favMovies = _favListSessionService.GetFavoriteMovies();

            _favMovieService.AddToFavMovie(favMovies, movieToBeAdded);

            _favListSessionService.SetFavoriteMovies(favMovies);

            TempData.Add("message", String.Format("{0},was succesfully added to the favorite list!", movieToBeAdded.Name));

            return RedirectToAction("Index", "Home");
        }

        public ActionResult List()
        {
            var favMovies = _favListSessionService.GetFavoriteMovies();
            FavListSummaryViewModel favListViewModel = new FavListSummaryViewModel
            {
                FavoriteMovies = favMovies 
            };
            return View(favListViewModel);
        }
        public ActionResult Remove(int movieId)
        {
            var favMovies = _favListSessionService.GetFavoriteMovies();
            _favMovieService.RemoveFromFavMovie(favMovies,movieId);
            _favListSessionService.SetFavoriteMovies(favMovies);

            TempData.Add("message", String.Format("Your movie was succesfully removed from the favorite list!"));
            return RedirectToAction("List");

        }

        public ActionResult Complete()
        {
            var memberDetailsViewModel = new MemberDetailsViewModel
            {
                MemberDetails = new MemberDetails()
            };
            return View(memberDetailsViewModel);
        }


        //Complete View'de Kaldık
        [HttpPost]
        public ActionResult Complete(MemberDetails memberDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", String.Format("Thank you {0}, your favorite movie list sended.", memberDetails.FirstName));
            return View();
        }

    }
}
