using System.Collections.Generic;
using System.Threading.Tasks;
using CarRental.API.Data;
using CarRental.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRental.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly Data.IBaseRepository<Car> _repo;

        public CarsController(IBaseRepository<Car> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            var cars = await _repo.GetObjects();
            return Ok(cars);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCar(int id)
        {
            var car = await _repo.GetObject(id);
            return Ok(car);
        }
    }
}