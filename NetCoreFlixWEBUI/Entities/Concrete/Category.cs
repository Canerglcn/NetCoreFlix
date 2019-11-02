using NetCoreFlixWEBUI.Entities.Abstract;
using NetCoreFlixWEBUI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.Entities
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public List<MovieCategory> MovieCategories { get; set; }
        public string Name { get; set; }
    }
}
