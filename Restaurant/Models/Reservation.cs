using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Reservation
    {
        [Key]
        public User User { get; set; }
        public DateTime DateTime { get; set; }
        public Table Table { get; set; }
        public string Description { get; set; }
    }
}
