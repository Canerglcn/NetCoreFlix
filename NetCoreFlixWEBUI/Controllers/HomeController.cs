using Microsoft.AspNetCore.Mvc;
using NetCoreFlixWEBUI.Business.Abstract;
using NetCoreFlixWEBUI.DataAccess.Abstract;
using NetCoreFlixWEBUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.Controllers
{
    public class HomeController : Controller
    {
        private IMovieService _movieService;

        public HomeController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public ActionResult Index(int page=1,int category=0)
        {
            int pageSize = 5;

            
            var movies = _movieService.GetByCategory(category);
            if (category == 0 || category == 16)
                movies = _movieService.GetAll();

            MovieListViewModel model = new MovieListViewModel
            {
                Movies = movies.Skip((page-1)*pageSize).Take(pageSize).ToList(),
                PageCount=(int)Math.Ceiling(movies.Count/(double)pageSize),
                PageSize=pageSize,
                CurrentCategory=category,
                CurrentPage=page
            };

            return View(model);
        }


    }
}
