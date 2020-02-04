using System;

namespace CarRental.API.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public Car Cars { get; set; }
        public User Users { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}