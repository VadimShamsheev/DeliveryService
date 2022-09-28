using System.Linq;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace DeliveryService.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CartId { get; set; }
        [Required]
        public bool IsDelivery { get; set; }  // Доставка(true) или самовывоз(false)
        [Required]
        public int RestId { get; set; }
        [Required]
        public bool IsPaid { get; set; }
        [Required]
        public DateTime DeliveryDateTime { get; set; }

        [ForeignKey(nameof(CartId))]
        public Cart CartEntity { get; set; }
    }
}
