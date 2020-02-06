using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CarRental.API.Data;
using CarRental.API.Dtos;
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
        private readonly IMapper _mapper;

        public CarsController(IBaseRepository<Car> repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            var cars = await _repo.GetObjects();
            var carsToReturn = _mapper.Map<IEnumerable<CarForListDto>>(cars);
            return Ok(carsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCar(int id)
        {
            var car = await _repo.GetObject(id);
            var carToReturn = _mapper.Map<CarForListDto>(car);
            return Ok(carToReturn);
        }
    }
}