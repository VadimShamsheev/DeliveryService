using System.Collections.Generic;

namespace DeliveryService.Models
{
    public interface ICategoriesRepository
    {
        public IEnumerable<Category> Categories { get; }
        public Category GetCategoryById(int id);
        
    }
}
