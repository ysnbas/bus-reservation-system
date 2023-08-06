using System.ComponentModel.DataAnnotations;

namespace otobusrezervasyonsistemi.Models
{
    public class BusArmchair
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int busID { get; set; }

        [Required]
        public bool DoluMu { get; set; }
    }
}
