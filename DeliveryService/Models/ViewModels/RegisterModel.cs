using System.ComponentModel.DataAnnotations;

namespace DeliveryService.Models.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Укажите почту")]
        [EmailAddress(ErrorMessage = "Укажите корректный адрес электронной почты")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Укажите пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Пароль не совпадает")]
        public string ConfirmPassword { get; set; }
    }
}
