using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreFlixWEBUI.Entities;

namespace NetCoreFlixWEBUI.Models
{
    public class MovieListViewModel
    {

     
        public List<Movie> Movies { get; internal set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
    }
}
