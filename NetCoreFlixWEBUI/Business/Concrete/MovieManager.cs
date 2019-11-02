using NetCoreFlixWEBUI.Business.Abstract;
using NetCoreFlixWEBUI.DataAccess.Abstract;
using NetCoreFlixWEBUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.Business.Concrete
{
    public class MovieManager : IMovieService
    {
        private IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public void Add(Movie movie)
        {
            _movieDal.Add(movie);
        }

        public void Delete(int movieId)
        {
            _movieDal.Delete(new Movie { MovieId = movieId });
        }

        public List<Movie> GetAll()
        {
            return _movieDal.GetList();
        }

        public List<Movie> GetByCategory(int categoryId)
        {
            return _movieDal.GetList(p=>p.CategoryId==categoryId|| categoryId==0);
        }

        public Movie GetById(int movieId)
        {
            return _movieDal.Get(p => p.MovieId == movieId);
        }

        public void Update(Movie movie)
        {
            _movieDal.Update(movie);
        }
    }
}
