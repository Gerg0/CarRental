using System.Collections.Generic;
using System.Threading.Tasks;
using CarRental.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.API.Data
{
    public class CarRepository : IBaseRepository<Car>
    {
        private readonly DataContext _context;
        public CarRepository(DataContext context)
        {
            _context = context;

        }
        public void Add(Car entity)
        {
            _context.Add(entity);
        }

        public void Delete(Car entity)
        {
            _context.Remove(entity);
        }

        public async Task<Car> GetObject(int id)
        {
            var car = await _context.Cars.Include(p => p.Photos).FirstOrDefaultAsync(c => c.Id == id);
            return car;
        }

        public async Task<IEnumerable<Car>> GetObjects()
        {
            var cars = await _context.Cars.Include(p => p.Photos).ToListAsync();
            return cars;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}