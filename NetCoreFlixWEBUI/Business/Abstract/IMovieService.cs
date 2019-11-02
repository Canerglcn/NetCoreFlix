using NetCoreFlixWEBUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.Business.Abstract
{
    public interface IMovieService
    {
        List<Movie> GetAll();
        List<Movie> GetByCategory(int categoryId);
        void Add(Movie movie);
        void Update(Movie movie);
        void Delete(int movieId);
        Movie GetById(int movieId);
    }
}
