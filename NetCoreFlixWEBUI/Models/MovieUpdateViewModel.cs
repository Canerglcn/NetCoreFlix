using System.Collections.Generic;
using NetCoreFlixWEBUI.Entities;

namespace NetCoreFlixWEBUI.Models
{
    public class MovieUpdateViewModel
    {
        public Movie Movie { get; set; }
        public List<Category> Categories { get; set; }
    }
}