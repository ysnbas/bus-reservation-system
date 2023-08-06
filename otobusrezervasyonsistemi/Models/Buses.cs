using System.ComponentModel.DataAnnotations;

namespace otobusrezervasyonsistemi.Models
{
    public class Buses
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Otobüs Markasını Giriniz")]
        public string BusName { get; set; }

        [Required(ErrorMessage = "Satılacak Koltuk Sayısını Giriniz")]
        public int TotalArmchair { get; set; }

    }
}
