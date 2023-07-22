using System.ComponentModel.DataAnnotations;

namespace otobusrezervasyonsistemi.Models
{
    public class Passenger
    {
        [Required(ErrorMessage = "Yolcu Adı Giriniz")]
        public string PassengerName { get; set; }

        [Required(ErrorMessage = "Yolcu TC No Giriniz")]
        public int TCNo { get; set; }
    }
}
