using System.Collections.Generic;

namespace CarRental.API.Dtos
{
    public class CarForListDto
    {
        public int Id { get; set; }
         public string Manufacturer { get; set; }
        public string Type { get; set; }
        public string LicensePlateNumber { get; set; }
        public int AverageConsumption { get; set; }
        public string Color { get; set; }
        public string Fuel { get; set; }
        public int NumberOfPassengers { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotosForRentalDto> Photos { get; set; }
    }
}