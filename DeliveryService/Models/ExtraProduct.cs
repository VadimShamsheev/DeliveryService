using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryService.Models
{
    public class ExtraProduct
    {
        public int ExtraId { get; set; }
        public int ProductId { get; set; }
        public int ExtraCount { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product ProductEntity { get; set; }
        [ForeignKey(nameof(ExtraId))]
        public Extra ExtraEntity { get; set; }
    }
}
