using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetCoreFlixWEBUI.Business.Abstract;
using NetCoreFlixWEBUI.Entities;
using NetCoreFlixWEBUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private IMovieService _movieService;
        private ICategoryService _categoryService;

        public AdminController(IMovieService movieService, ICategoryService categoryService)
        {
            _movieService = movieService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var movieListViewModel = new MovieListViewModel
            {
                Movies = _movieService.GetAll()
            };
            return View(movieListViewModel);
        }

        public ActionResult Add()
        {
            var model = new MovieAddViewModel
            {
                Movie = new Movie(),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieService.Add(movie);
                TempData.Add("message", "Movie was successfully added");
            }

            return RedirectToAction("Add");
        }

        public ActionResult Update(int movieId)
        {
            var model = new MovieUpdateViewModel
            {
                Movie = _movieService.GetById(movieId),
                Categories = _categoryService.GetAll()
            };

            return View(model);

        }
       


        [HttpPost]
        public ActionResult Update(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieService.Update(movie);
                TempData.Add("message", "Movie was successfully updated");
            }
            return RedirectToAction("Update");
        }

        public ActionResult Delete(int movieId)
        {
            _movieService.Delete(movieId);
            TempData.Add("message", "Movie was successfully deleted");
            return RedirectToAction("Index");
        }

    }
}
