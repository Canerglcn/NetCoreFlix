using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.Entities.Concrete
{
    public class FavoriteMovie
    {
        public Movie Movie { get; set; }
        public int GivenScore { get; set; }
    }
}
