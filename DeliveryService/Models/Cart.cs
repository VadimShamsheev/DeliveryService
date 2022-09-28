using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryService.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ClientId { get; set; }

        [ForeignKey(nameof(ClientId))]
        public Client ClientEntity { get; set; }
    }
}
