using System.Linq;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryService.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public bool IsDelivery { get; set; }  // Доставка(true) или самовывоз(false)
        public int RestId { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DeliveryDateTime { get; set; }

        [ForeignKey(nameof(ClientId))]
        public Client ClientEntity { get; set; }

        /*public ICollection<Product> ProductEntities { get; set; }
        public List<OrderProduct> OrderProductEntity { get; set; }*/
    }
}
