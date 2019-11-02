using System.Collections.Generic;
using NetCoreFlixWEBUI.Entities;

namespace NetCoreFlixWEBUI.Models
{
    public class MovieAddViewModel
    {
        public Movie Movie { get; set; }
        public List<Category> Categories { get; set; }
    }
}