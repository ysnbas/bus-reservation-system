using System.ComponentModel.DataAnnotations;

namespace otobusrezervasyonsistemi.Models
{
    public class Tickets
    {
        [Key]
        public int id {  get; set; }
        [Required]
        public int routeID { get; set; }

        [Required]
        public int passengersID { get; set; }

        [Required]
        public DataType biletTarihi { get; set; }

        [Required]
        public int koltukNumarası { get; set; }
    }
}
