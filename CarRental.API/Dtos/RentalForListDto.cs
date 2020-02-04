using System;

namespace CarRental.API.Dtos
{
    public class RentalForListDto
    {
        public int Id { get; set; }
        public CarForRentalDto Cars { get; set; }
        public UserForRentalDto Users { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}