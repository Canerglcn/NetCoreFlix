using NetCoreFlixWEBUI.DataAccess.Abstract;
using NetCoreFlixWEBUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.DataAccess.Concrete
{
    public class CategoryDal:EfEntityRepositoryBase<Category,NetCoreFlixContext>,ICategoryDal
    {
    }
}
