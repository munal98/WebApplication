using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApplication.ViewComponents
{
    public class Categories : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BL.CategoryManager categoryManager = new BL.CategoryManager();

            return View(categoryManager.GetAll());
        }
    }
}
