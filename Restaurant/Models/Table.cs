using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Table
    {
        [Key]
        public int Id { get; set; }
        public int Seats { get; set; }
        public bool IsSmoking { get; set; }
    }
}
