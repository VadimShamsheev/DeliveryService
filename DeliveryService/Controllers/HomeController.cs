using DeliveryService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeliveryService.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _repo;

        public HomeController(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Index(int Id = 0)
        {
            if (Id == 0)
            {
                return View(_repo.Products);
            }
            else
            {
                List<Product> p = _repo.GetProductsByCategory(Id).ToList();
                StringBuilder listStr = new StringBuilder();
                foreach (Product product in p)
                {
                    listStr.Append($"<li><a href='{ Url.Action("ProductDetails", "Home", product.Id) }'>{ product.Name }</a></li>");
                }
                return Content(listStr.ToString());
            }
        }
        [Authorize]
        public ViewResult ProductDetails(int id)
        {
            return View(_repo.GetProductById(id));
        }
    }
}
