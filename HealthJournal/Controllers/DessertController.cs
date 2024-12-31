using HealthJournal.Models;
using HealthJournal.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthJournal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DessertController : ControllerBase
    {
        private readonly DessertService _dessertService;

        public DessertController(DessertService dessertService)
        {
            _dessertService = dessertService;
        }

        [HttpGet]
        public async Task<List<Dessert>> Get() => await _dessertService.GetDessertsAsync();

        [HttpPost]
        public async Task<IActionResult> Create(Dessert newDessert)
        {
            await _dessertService.CreateDessertAsync(newDessert);

            return Ok();
        }
    }
}
