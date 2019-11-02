using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using NetCoreFlixWEBUI.DataAccess.Abstract;
using NetCoreFlixWEBUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private ICategoryDal _categoryDal;
        public CategoryListViewComponent(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryDal.GetList(),
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["category"])

            };
            return View(model);
        }
    }
}
