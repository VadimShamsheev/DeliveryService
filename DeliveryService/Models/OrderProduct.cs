using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryService.Models
{
    public class OrderProduct
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order OrderEntity { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product ProductEntity { get; set; }
    }
}
