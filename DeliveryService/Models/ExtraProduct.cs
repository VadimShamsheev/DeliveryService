using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryService.Models
{
    public class ExtraProduct
    {
        [Key]
        public int ProductInCartId { get; set; }
        [Required]
        public int ExtraId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int ExtraCount { get; set; }

        [ForeignKey(nameof(ProductInCartId))]
        public CartProduct ProductInCartEntity { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product ProductEntity { get; set; }
        [ForeignKey(nameof(ExtraId))]
        public Extra ExtraEntity { get; set; }
    }
}
