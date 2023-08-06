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
        public char TCNo { get; set; }
    }
}
