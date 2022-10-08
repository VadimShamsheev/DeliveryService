using Microsoft.AspNetCore.Mvc;
using System.Linq;
using DeliveryService.Models;

namespace DeliveryService.Components
{
    public class CategoriesMenuViewComponent : ViewComponent
    {
        private ICategoriesRepository _categoriesRepository;

        public CategoriesMenuViewComponent(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View(_categoriesRepository.Categories);
        }
    }
}
