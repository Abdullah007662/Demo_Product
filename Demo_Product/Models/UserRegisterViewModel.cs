using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen İsim Giriniz")]
        public string? İsim { get; set; }

        [Required(ErrorMessage = "Lütfen Soyİsim Giriniz")]
        public string? Soyİsim { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz")]
        [EmailAddress(ErrorMessage ="Geçerli Bir Mail Giriniz")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz")]
        public string? KulAD { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string? Şifre { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz")]
        [Compare("Şifre", ErrorMessage = "Lütfen Şifrelerin Eşleştiğinden Emin Olun")]
        public string? ŞifreTekrar { get; set; }
    }
}
