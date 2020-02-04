using System.Collections.Generic;
using System.Linq;
using CarRental.API.Models;
using Newtonsoft.Json;
using System.IO;

namespace CarRental.API.Data
{
    public class Seed
    {
        public static void SeedUsers(DataContext context)
        {
            if (!context.Users.Any())
            {
                var userData = File.ReadAllText("Data/UserSeedData.json");
                var users = JsonConvert.DeserializeObject<List<User>>(userData);
                foreach (var user in users)
                {
                    byte[] passwordhash, passwordsalt;
                    CreatePasswordHash("password", out passwordhash, out passwordsalt);

                    user.PasswordHash = passwordhash;
                    user.PasswordSalt = passwordsalt;
                    user.Name = user.Name.ToLower();

                    context.Users.Add(user);
                }
                context.SaveChanges();
            }
        }
        public static void SeedCars(DataContext context)
        {
            if (!context.Cars.Any())
            {
                var carData = File.ReadAllText("Data/CarSeedData.json");
                var cars = JsonConvert.DeserializeObject<List<Car>>(carData);
                foreach (var car in cars)
                {
                    context.Cars.Add(car);
                }
                context.SaveChanges();
            }
        }

        public static void SeedRentals(DataContext context)
        {
            if (!context.Rentals.Any())
            {
                var rentalData = File.ReadAllText("Data/RentalSeedData.json");
                var rentals = JsonConvert.DeserializeObject<List<Rental>>(rentalData);
                foreach (var rental in rentals)
                {
                    byte[] passwordhash, passwordsalt;
                    CreatePasswordHash("password", out passwordhash, out passwordsalt);

                    rental.Users.PasswordHash = passwordhash;
                    rental.Users.PasswordSalt = passwordsalt;
                    rental.Users.Name = rental.Users.Name.ToLower();
                    context.Rentals.Add(rental);
                }
                context.SaveChanges();
            }
        }
        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

        }
    }
}