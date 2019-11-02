using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.Entities.Concrete
{
    public class FavoriteMovies
    {
        public FavoriteMovies()
        {
            FavoriteMovieList = new List<FavoriteMovie>();
        }
        public List<FavoriteMovie> FavoriteMovieList { get; set; }

        public decimal Total
        {
            get { return FavoriteMovieList.Sum(c=>c.GivenScore); }
        }
    }
}
