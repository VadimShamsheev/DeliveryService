using System.Collections.Generic;
using System.Linq;

namespace DeliveryService.Models
{
    public class EFCategoryRepository : ICategoriesRepository
    {
        private ApplicationContext _context;
        public IEnumerable<Category> Categories => _context.Categories.ToList();
        
        public EFCategoryRepository(ApplicationContext context) => _context = context;

        public Category GetCategoryById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }
    }
}
