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

        public HomeController(IProductRepository repo) => _repo = repo;

        [HttpGet]
        public IActionResult Index() => View(_repo.Products);
        
        /// <summary>
        /// Метод для выбора категории с использованием AJAX
        /// </summary>
        /// <param name="Id">Номер категории</param>
        /// <returns>Частичное представление списка продуктов</returns>
        public IActionResult CategorySort(int Id)
        {
            IEnumerable<Product> productTempList = new List<Product>();
            if (Id == 0)
            {
                productTempList = _repo.Products;
            }
            else
            {
                productTempList = _repo.GetProductsByCategory(Id);
            }
            return PartialView("ProductsListPartial", productTempList);
        }
        [Authorize]
        public ViewResult ProductDetails(int id)
        {
            return View(_repo.GetProductById(id));
        }
    }
}
