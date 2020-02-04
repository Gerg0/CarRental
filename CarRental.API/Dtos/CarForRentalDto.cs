using System.Collections.Generic;
using CarRental.API.Models;

namespace CarRental.API.Dtos
{
    public class CarForRentalDto
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public string LicensePlateNumber { get; set; }
        public int NumberOfPassengers { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotosForRentalDto> Photos { get; set; }
    }
}