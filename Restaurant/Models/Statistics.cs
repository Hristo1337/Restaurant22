using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Statistics
    {
        [Key]
        public int NumberOfTables { get; set; }
        public int NumberOfCustomers { get; set; }
        public int NumberOfPastReservations { get; set; }
        public int NumberOfUpcomingReservations { get; set; }
    }
}
