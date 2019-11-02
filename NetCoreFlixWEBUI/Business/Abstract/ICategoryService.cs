using NetCoreFlixWEBUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
