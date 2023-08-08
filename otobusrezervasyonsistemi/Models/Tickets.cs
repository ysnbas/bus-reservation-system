using System.ComponentModel.DataAnnotations;

namespace otobusrezervasyonsistemi.Models
{
    public class Tickets
    {
        [Key]
        public int id {  get; set; }
        [Required]
        public string busname { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public string kalkis { get; set; }
        [Required]
        public string varis { get; set; }

        [Required]
        public int userID { get; set; }

        [Required]
        public string biletTarihi { get; set; }

        [Required]
        public int armchairNo { get; set; }
    }
}
