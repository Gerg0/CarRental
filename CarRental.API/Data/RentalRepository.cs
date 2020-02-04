using System.Collections.Generic;
using System.Threading.Tasks;
using CarRental.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.API.Data
{
    public class RentalRepository : IBaseRepository<Rental>
    {
        private readonly DataContext _context;
        public RentalRepository(DataContext context)
        {
            _context = context;
        }
        public void Add(Rental entity)
        {
            _context.Add(entity);
        }

        public void Delete(Rental entity)
        {
            _context.Remove(entity);
        }

        public async Task<Rental> GetObject(int id)
        {
            var rental = await _context.Rentals.Include(c => c.Cars).Include(p => p.Cars.Photos).Include(u => u.Users).FirstOrDefaultAsync(u => u.Id == id);
            return rental;
        }

        public async Task<IEnumerable<Rental>> GetObjects()
        {
            var rentals = await _context.Rentals.Include(c => c.Cars).Include(p => p.Cars.Photos).Include(u => u.Users).ToListAsync();
            return rentals;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}