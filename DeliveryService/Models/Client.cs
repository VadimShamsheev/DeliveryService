using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DeliveryService.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Address Address { get; set; }
        public int Discount { get; set; }

        [ForeignKey(nameof(Id))]
        public UserData UserEntity { get; set; }
    }
    [Owned]
    public class Address
    {
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string HouseNumber { get; set; }
        public int Entrance { get; set; }
        public int Floor { get; set; }
        public int ApartmentNumber { get; set; }
    }
}
