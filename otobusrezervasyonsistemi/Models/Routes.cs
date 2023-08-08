using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace otobusrezervasyonsistemi.Models
{
    public class Routes
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int busID { get; set; }
        [Required]
        public int Ticket { get; set; }

        [Required(ErrorMessage = "Otobüs Seçiniz")]
        public string BusName { get; set; }
        [Required(ErrorMessage = "Gidiş Seçiniz")]
        public string Departure { get; set; }

        [Required(ErrorMessage = "Varış Seçiniz")]
        public string Arrival { get; set; }

        [Required(ErrorMessage = "Bilet Fiyatı Giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Yolculuk Tarihini Seçiniz")]
        public string Date { get; set; }
    }
}
