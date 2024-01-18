using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class User
    {
        [Key]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Reservation> Reservations { get; set; }
    }

}
