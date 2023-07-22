using System.ComponentModel.DataAnnotations;

namespace otobusrezervasyonsistemi.Models
{
    public class Users
    {
        [Required(ErrorMessage = "Kullanıcı Adı Giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email Giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon Giriniz")]
        public int Phone { get; set; }
    }
}
