using System.ComponentModel.DataAnnotations;

namespace DeliveryService.Models.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Укажите почту")]
        [EmailAddress(ErrorMessage = "Укажите корректный адрес электронной почты")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Укажите пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
