using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeliveryService.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public IEnumerable<Product> ProductsDBEntities { get; set; }
    }
}
