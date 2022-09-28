using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryService.Models
{
    public class CartProduct
    {
        [Key]
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        
        [ForeignKey(nameof(CartId))]
        public Cart CartEntity { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product ProductEntity { get; set; }
    }
}
