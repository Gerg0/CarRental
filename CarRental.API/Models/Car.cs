using System.Collections.Generic;

namespace CarRental.API.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public string LicensePlateNumber { get; set; }
        public int AverageConsumption { get; set; }
        public string Color { get; set; }
        public string Fuel { get; set; }
        public int NumberOfPassengers { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}