using System.ComponentModel.DataAnnotations;

namespace otobusrezervasyonsistemi.Models
{
    public class Passengers
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Yolcu Adı Giriniz")]
        public string PassengerName { get; set; }

        [Required(ErrorMessage = "Yolcu Soy adı Giriniz")]
        public string PassengerSurname { get; set; }

        [Required(ErrorMessage = "Yolcu TC No Giriniz")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Geçerli TC Değil")]
        public string TCNo { get; set; }
    }
}
