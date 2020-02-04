namespace CarRental.API.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
    }
}