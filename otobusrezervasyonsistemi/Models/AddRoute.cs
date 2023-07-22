using System.ComponentModel.DataAnnotations;

namespace otobusrezervasyonsistemi.Models
{
    public class AddRoute
    {
        [Required(ErrorMessage = "Otobüs Seçiniz")]
        public string BusName { get; set; }
        [Required(ErrorMessage = "Gidiş Seçiniz")]
        public string Departure { get; set; }

        [Required(ErrorMessage = "Varış Seçiniz")]
        public string Arrival { get; set; }

        [Required(ErrorMessage = "Bilet Fiyatı Giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Yolculuk Tarihini Seçiniz")]
        public DateTime Date { get; set; }

    }
}
