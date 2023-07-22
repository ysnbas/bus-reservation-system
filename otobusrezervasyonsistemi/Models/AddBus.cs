using System.ComponentModel.DataAnnotations;

namespace otobusrezervasyonsistemi.Models
{
    public class AddBus
    {
        [Required(ErrorMessage = "Otobüs Markasını Giriniz")]
        public string BusName { get; set; }

        [Required(ErrorMessage = "Satılacak Koltuk Sayısını Giriniz")]
        public int TotalArmchair { get; set; }

    }
}
