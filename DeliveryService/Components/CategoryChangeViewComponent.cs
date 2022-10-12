using Microsoft.AspNetCore.Mvc;
using System.Linq;
using DeliveryService.Models.ViewModels;

namespace DeliveryService.Components
{
    public class CategoryChangeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new CategoryChangeViewModel());
        }
    }
}
