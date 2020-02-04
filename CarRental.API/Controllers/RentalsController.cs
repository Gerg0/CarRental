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
    public class RentalsController : ControllerBase
    {
        private readonly IBaseRepository<Rental> _repo;
        private readonly IMapper _mapper;

        public RentalsController(IBaseRepository<Rental> repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetRentals()
        {
            var rentals = await _repo.GetObjects();
            var rentalsToReturn = _mapper.Map<IEnumerable<RentalForListDto>>(rentals);
            return Ok(rentalsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRental(int id)
        {
            var rental = await _repo.GetObject(id);
            var rentalToReturn = _mapper.Map<RentalForListDto>(rental);
            return Ok(rentalToReturn);
        }
    }
}