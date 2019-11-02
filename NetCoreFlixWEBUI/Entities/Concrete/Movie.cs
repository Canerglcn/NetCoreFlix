using NetCoreFlixWEBUI.Entities.Abstract;
using NetCoreFlixWEBUI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.Entities
{
    public class Movie:IEntity
    {
       
        public int MovieId { get; set; }
        [Required]
        public int CategoryId { get; set; }
      
        public List<MovieCategory> MovieCategories { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string ImageUrl { get; set; }

    }
}
